using DofusTeamManager.Utils;
using System.Collections.Generic;
using static DofusTeamManager.Data.Race;
using static DofusTeamManager.Data.Servor;

namespace DofusTeamManager.Data
{
    internal class Character
    {
        private string Name;
        private Account Account;
        private Races Race;
        private Servors Servor;

        public Character(string name, Account account, Races race, Servors servor)
        {
            Name = name;
            Account = account;
            Race = race;
            Servor = servor;
        }

        public bool IsSubscribed()
        {
            return Account.IsSubscribed;
        }

        public bool CanAllyWith(Character other)
        {
            if (other.Servor != Servor) return false;
            if (other.Account == Account) return false;
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
            string achievementsFilePath = "Data/Achievements" + Servor.ToString() + ".csv";
            if(!FileManager.Exists(achievementsFilePath))
            {
                FileManager.CopyFile("Data/Achievements.csv", achievementsFilePath);
            }
            FileManager.AddColumnToCsvFile(achievementsFilePath, Name);
        }

    }
}
