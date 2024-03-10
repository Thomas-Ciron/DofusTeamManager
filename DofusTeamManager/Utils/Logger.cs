using System;
using System.Collections.Generic;

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

        public static void SaveList<T>(string message, List<T> list)
        {
            Save(message + ": [" + string.Join(", ", list) + "]");
        }

        public static void SaveTitle(string message)
        {
            Save("=== " +  message + " ==="); 
        }
    }
}
