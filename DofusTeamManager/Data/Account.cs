using DofusTeamManager.Utils;
using System;
using System.Collections.Generic;

namespace DofusTeamManager.Data
{
    internal class Account
    {
        public string Name;
        public bool IsSubscribed;

        public static Account GetFromString(string str)
        {
            List<List<string>> accountsData = FileManager.GetCsvContent("Data/Accounts.csv");
            foreach (List<string> accountData in accountsData)
            {
                if (accountData[0] == str)
                {
                    return new Account(accountData[0], accountData[1]);
                }
            }
            throw new Exception("Error: Unknown account: " + str);
        }

        public Account(string name, bool isSubscribed)
        {
            Name = name;
            IsSubscribed = isSubscribed;
        }

        public Account(string name, string isSubscribed)
        {
            Name = name;
            IsSubscribed = isSubscribed == "1";
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            List<List<string>> accountsData = FileManager.GetCsvContent("Data/Accounts.csv");
            foreach(List<string> accountData in accountsData)
            {
                accounts.Add(new Account(accountData[0], accountData[1]));
            }
            return accounts;
        }
        public static List<string> GetAll()
        {
            List<Account> accounts = GetAccounts();
            List<string> result = new List<string>();
            foreach(Account account in accounts)
            {
                result.Add(account.Name);
            }
            return result;
        }
    }
}
