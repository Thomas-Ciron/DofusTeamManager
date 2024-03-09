using System;
using System.Collections.Generic;
using static DofusTeamManager.Data.Servor;

namespace DofusTeamManager.Data
{
    internal class Servor
    {
        public enum Servors
        {
            Imagiro,
            Draconiros,
            Orukam,
            HellMina,
            TalKasha,
            Tylezia,
            Ombre,
            Temporis
        }

        public static List<string> GetAll()
        {
            List<string> list = new List<string>();
            foreach (Servors servor in Enum.GetValues(typeof(Servors))) list.Add(servor.ToString());
            return list;
        }

        public static Servors GetFromString(string str)
        {
            foreach (Servors servor in Enum.GetValues(typeof(Servors)))
            {
                if (servor.ToString() == str) return servor;
            }
            throw new Exception("Unknown servor: " + str);
        }
    }

    internal static class ServorsExtension
    {
        public static bool IsMonoAccountServor(this Servors servor)
        {
            switch (servor)
            {
                case Servors.Imagiro:
                case Servors.Orukam:
                case Servors.HellMina:
                case Servors.TalKasha:
                case Servors.Tylezia:
                case Servors.Ombre:
                    return false;
                case Servors.Draconiros:
                case Servors.Temporis:
                    return true;
                default:
                    Console.WriteLine("Warning: unknown servor : " + servor);
                    return false;
            }
        }

        public static int GetPartySize(this Servors servor)
        {
            if (servor.IsMonoAccountServor())
            {
                return 1;
            }
            else
            {
                return 8;
            }
        }
    }
}
