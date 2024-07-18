using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class AccountBUS
    {
        AccountDAL accountDAL=new AccountDAL();
        public List<Account> GetAllAccount()
        {
            return accountDAL.GetAllAccount();
        }
        public List<string> GetAllIDAccount()
        {
            var listAccount = GetAllAccount();
            var listIDAccount = new List<string>();
            foreach (var account in listAccount)
            {
                listIDAccount.Add(account.Idaccount);
            }
            return listIDAccount;
        }
        public bool AddNewAccount(string idAccount, string passAccount, string accountName, string email, int accountLevel, bool accountStaus)
        {
            Account account = new Account()
            {
                Idaccount = idAccount,
                PassAccount = passAccount,
                AccountName = accountName,
                Email = email,
                AccountLevel = accountLevel,
                AccountStatus = accountStaus
            };
            if (accountDAL.AddNewAccount(account))
            {
                return true;
            }
            else
                return false;
        }
        public bool UpdateAccount(string idAccount, string passAccount, string accountName, string email, int accountLevel, bool accountStaus)
        {
            Account account = new Account()
            {
                Idaccount = idAccount,
                PassAccount = passAccount,
                AccountName = accountName,
                Email = email,
                AccountLevel = accountLevel,
                AccountStatus = accountStaus
            };
            if (accountDAL.UpdateAccount(account))
            {
                return true;
            }
            else
                return false;
        }
    }
}
