using System;

namespace DofusTeamManager.Utils
{
    internal class Logger
    {
        public static string GetCurrentTime()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate.ToString("dd/MM/yyyy HH:mm") + "\t";
        }
        public static void Save(string message)
        {
            FileManager.AddContentToFile("logs.txt", GetCurrentTime() + message);
        }

        public static void SaveTitle(string message)
        {
            Save("=== " +  message + " ==="); 
        }
    }
}
