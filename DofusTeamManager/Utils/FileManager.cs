﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DofusTeamManager.Utils
{
    internal class FileManager
    {
        public static List<string> GetFileLines(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Logger.Save($"No such file: {filePath}");
                return null;
            }
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if(!string.IsNullOrWhiteSpace(line)) lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Save($"An error occured while reading {filePath}: {ex.Message}");
            }
            return lines;
        }

        public static List<List<string>> GetCsvContent(string filePath)
        {
            List<string> fileLines = GetFileLines(filePath);
            if (fileLines == null) return null;

            List<List<string>> csvContent = new List<List<string>>();
            foreach(string line  in fileLines)
            {
                string[] columns = line.Split(';');
                csvContent.Add(new List<string>(columns));
            }
            return csvContent;
        }

        public static void WriteContentInFile(string filePath, string content)
        {
            using(StreamWriter writer = File.CreateText(filePath))
            {
                writer.WriteLine(content);
            }
        }

        public static void AddContentToFile(string filePath, string content)
        {
            if (!File.Exists(filePath))
            {
                WriteContentInFile(filePath, content);  
                return;
            }
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(content);
                }
            }
            catch (Exception ex) { Console.WriteLine($"Error: couldn't append content to {filePath} : {ex.Message}"); }

        }

        public static void AddRowToCsvFile(string filePath, List<string> rowElements)
        {
            AddContentToFile(filePath, string.Join(";", rowElements));
        }
        
        public static void WriteLinesInFile(string filePath, List<string> lines)
        {
            WriteContentInFile(filePath, string.Join("\n", lines));
        }

        public static void AddColumnToCsvFile(string filePath, string column)
        {
            List<string> lines = GetFileLines(filePath);
            for (int i = 0; i < lines.Count; i++) lines[i] += ";" + column;
            WriteLinesInFile(filePath, lines);
        }

        public static bool Exists(string filePath)
        {
            return File.Exists(filePath);
        }

        public static void CopyFile(string source, string destination)
        {
            string fileContent = File.ReadAllText(source);
            WriteContentInFile(destination, fileContent);
        }

        public static void SaveMatrixInCsv(string filePath, List<List<string>> matrix)
        {
            List<string> lines = new List<string>();
            foreach(List<string> line in matrix)
            {
                lines.Add(string.Join(";", line));
            }
            WriteLinesInFile(filePath, lines);
        }

        public static List<string> GetCsvRowElements(string filePath, string firstColumnContent)
        {
            List<List<string>> csvContent = GetCsvContent(filePath);
            if (csvContent == null) return null;
            foreach (List<string> line in csvContent)
            {
                if (line[0] == firstColumnContent) return line;
            }
            return null;
        }

        public static List<int> GetBytesFrom(string filePath)
        {
            if(!Exists(filePath)) return null;
            List<int> bytes = new List<int>();
            byte[] data = File.ReadAllBytes(filePath);
            foreach (byte b in data) bytes.Add(b);
            return bytes;
        }

        public static void WriteBytesInFile(string filePath, List<byte> bytes)
        {
            File.WriteAllBytes(filePath, bytes.ToArray());
        }
    }
}
