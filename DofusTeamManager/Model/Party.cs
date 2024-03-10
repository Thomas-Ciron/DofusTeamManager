using DofusTeamManager.Data;
using DofusTeamManager.Utils;
using System.Collections.Generic;
using static DofusTeamManager.Data.Servor;

namespace DofusTeamManager.Model
{
    internal class Party
    {
        public List<Character> Characters;
        private readonly List<Character> Candidates;
        private readonly int PartyMaxSize;
        private readonly Servors Servor;

        private void SortCandidatesPerNbrAchievementsToDo()
        {
            bool isSorted = false;
            int i;
            Character tmp;
            while (!isSorted)
            {
                isSorted = true;
                for (i = 1; i < Candidates.Count; ++i)
                {
                    if (Candidates[i].HasMoreAchievementsToDoThan(Candidates[i - 1]))
                    {
                        tmp = Candidates[i];
                        Candidates[i] = Candidates[i - 1];
                        Candidates[i - 1] = tmp;
                        isSorted = false;
                    }
                }
            }
        }

        public Party(Servors servor)
        {
            Logger.Save($"Building party for servor {servor}...");
            Servor = servor;
            PartyMaxSize = servor.GetPartySize();
            Characters = new List<Character>();
            Candidates = Character.GetAll(servor);
            SortCandidatesPerNbrAchievementsToDo();
            int i = 0;
            while(i < Candidates.Count && !IsFull())
            {
                if (CanCharacterJoin(Candidates[i])) Add(Candidates[i]);
                ++i;
            }
            Logger.SaveList("Party built", Characters);
        }

        public Party(Servors servor, string achievement)
        {
            Logger.Save($"Building party for servor {servor} and achievement {achievement}...");
            Candidates = Character.GetAll(servor);
            Servor = servor;
            PartyMaxSize = servor.GetPartySize();
            LoadLastParty(achievement);
            int i = 0;
            while(i < Candidates.Count && !IsFull())
            {
                Logger.Save($"\tChecking for {Candidates[i]}");
                if (ShouldJoinParty(Candidates[i], achievement)) Characters.Add(Candidates[i]);
                ++i;
            }
            Logger.SaveList("Party built", Characters);
        }

        public bool ShouldJoinParty(Character character, string achievement)
        {
            if (!CanCharacterJoin(character)) return false;
            if (!character.ShouldDoAchievement(achievement)) return false;
            if (!character.CanDoAchievement(achievement)) return false;
            return true;
        }

        public string GetPartySavePath()
        {
            return $"Data/Party{Servor}.bin";
        }

        public void LoadLastParty(string achievement)
        {
            Characters = new List<Character>();
            List<int> characterIndexes = FileManager.GetBytesFrom(GetPartySavePath());
            if (characterIndexes == null) return;
            foreach(int index in  characterIndexes)
            {
                if (Candidates[index].ShouldDoAchievement(achievement) && Candidates[index].CanDoAchievement(achievement))
                {
                    Characters.Add(Candidates[index]);
                }
            }
        }

        public List<string> GetCandidates(Character characterToReplace)
        {
            List<string> candidates = new List<string>();
            foreach(Character candidate in Candidates)
            {
                if (CanCharacterJoin(candidate)) candidates.Add(candidate.Name);
                else if (candidate.Account.Name == characterToReplace.Account.Name) candidates.Add(candidate.Name);
            }
            return candidates;
        }

        public bool IsFull()
        {
            return Characters.Count >= PartyMaxSize;
        }

        public bool CanCharacterJoin(Character character)
        {
            if (IsFull()) return false;
            if (!character.IsSubscribed()) return false;
            foreach (Character mate in Characters)
            {
                if (!character.CanAllyWith(mate)) return false;
            }
            return true;
        }

        public void Add(Character character)
        {
            Characters.Add(character);
        }

        public bool ShouldDoStep(string achievement)
        {
            foreach(Character mate in Characters)
            {
                if(mate.ShouldDoAchievement(achievement)) return true;
            }
            return false;
        }

        public List<string> GetStepsToDo(List<string> steps)
        {
            List<string> stepsToDo = new List<string>();
            foreach (string step in steps)
            {
                if (ShouldDoStep(step)) stepsToDo.Add(step);
            }
            return stepsToDo;
        }

        public void Performed(string achievement)
        {
            List<List<string>> achievements = FileManager.GetCsvContent("Data/Achievements" + Servor + ".csv");
            int i = 0;
            while (i < achievements.Count && achievements[i][0] != achievement) ++i;
            List<byte> bytes = new List<byte>();
            foreach(Character character in Characters)
            {
                if(character.ShouldDoAchievement(achievement))
                {
                    character.AchievementsToDo.Remove(achievement);
                    achievements[i].Remove(character.Name);
                }
                bytes.Add((byte)Candidates.IndexOf(character));
            }
            FileManager.SaveMatrixInCsv("Data/Achievements" + Servor + ".csv", achievements);
            FileManager.WriteBytesInFile(GetPartySavePath(), bytes);
        }


    }
}
