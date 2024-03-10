using DofusTeamManager.Utils;
using System;
using System.Collections.Generic;
using static DofusTeamManager.Data.Race;
using static DofusTeamManager.Data.Servor;

namespace DofusTeamManager.Data
{
    internal class Character
    {
        public readonly string Name;
        public readonly Account Account;
        private readonly Races Race;
        private readonly Servors Servor;
        public readonly List<string> AchievementsToDo;

        public Character(string name, Account account, Races race, Servors servor)
        {
            Name = name;
            Account = account;
            Race = race;
            Servor = servor;
            AchievementsToDo = new List<string>();
            List<List<string>> achievementsData = FileManager.GetCsvContent(GetAchievementsFilePath());
            foreach (List<string> achievementData in achievementsData)
            {
                if (achievementData.Contains(Name)) AchievementsToDo.Add(achievementData[0]);
            }
        }

        public bool IsSubscribed()
        {
            return Account.IsSubscribed;
        }

        public bool CanAllyWith(Character other)
        {
            if (other.Servor != Servor) return false;
            if (other.Account.Name == Account.Name) return false;
            return true;
        }

        public void Add()
        {
            AddCharacterToCharacterCsvFile();
            AddCharacterToAchievementsToDo();
        }

        private List<string> ToStringList()
        {
            List<string> list = new List<string>
            {
                Name,
                Account.Name,
                Race.ToString(),
                Servor.ToString()
            };
            return list;
        }

        private void AddCharacterToCharacterCsvFile()
        {
            FileManager.AddRowToCsvFile("Data/Characters.csv", ToStringList());    
        }

        private void AddCharacterToAchievementsToDo()
        {
            string achievementsFilePath = GetAchievementsFilePath();
            if(!FileManager.Exists(achievementsFilePath))
            {
                FileManager.CopyFile("Data/Achievements.csv", achievementsFilePath);
            }
            FileManager.AddColumnToCsvFile(achievementsFilePath, Name);
        }

        public string GetAchievementsFilePath()
        {
            return "Data/Achievements" + Servor.ToString() + ".csv";
        }

        public static List<Character> GetAll(Servors servor)
        {
            List <Character> list = new List<Character>();
            List<List<string>> charactersData = FileManager.GetCsvContent("Data/Characters.csv");
            string servorTargeted = servor.ToString();
            foreach (List<string> characterData in charactersData)
            {
                if (characterData[3] == servorTargeted)
                {
                    list.Add(new Character(
                        characterData[0],
                        Account.GetFromString(characterData[1]),
                        Data.Race.GetFromString(characterData[2]),
                        servor
                        )) ;
                }
            }
            return list;
        }

        public bool ShouldDoAchievement(string achievement)
        {
            return AchievementsToDo.Contains(achievement);
        }

        public bool CanDoAchievement(string achievement)
        {
            List<string> requirements = FileManager.GetCsvRowElements("Data/Préréequis.csv", achievement);
            if (requirements == null) return true;
            for(int i = 1; i < requirements.Count; i++)
            {
                if (ShouldDoAchievement(requirements[i])) return false;
            }
            return true;
        }

        public bool HasMoreAchievementsToDoThan(Character other)
        {
            return AchievementsToDo.Count > other.AchievementsToDo.Count;
        }

        public void HasAlreadyDone(string achievement)
        {
            AchievementsToDo.Remove(achievement);

            List<List<string>> achievementsData = FileManager.GetCsvContent(GetAchievementsFilePath());
            for(int i = 0;  i < achievementsData.Count; i++)
            {
                if (achievementsData[i][0] == achievement)
                {
                    achievementsData[i].Remove(Name);
                    FileManager.SaveMatrixInCsv(GetAchievementsFilePath(), achievementsData);
                    return;
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
