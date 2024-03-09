using static DofusTeamManager.Data.Servor;
using System.Collections.Generic;
using System;

namespace DofusTeamManager.Data
{
    internal class Race
    {
        public enum Races
        {
            Iop,
            Cra,
            Sacrieur,
            Eniripsa,
            Sram,
            Ouginak,
            Forgelance,
            Osamodas,
            Enutrof,
            Ecaflip,
            Steamer,
            Feca,
            Huppermage,
            Zobal,
            Pandawa,
            Eliotrope,
            Sadida,
            Roublard,
            Xelor
        }

        public static List<string> GetAll()
        {
            List<string> list = new List<string>();
            foreach (Races race in Enum.GetValues(typeof(Races))) list.Add(race.ToString());
            return list;
        }

        public static Races GetFromString(string str)
        {
            foreach (Races race in Enum.GetValues(typeof(Races)))
            {
                if (race.ToString() == str) return race;
            }
            throw new Exception("Unknown servor: " + str);
        }
    }
}
