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
        AccountDAL AccountDAL=new AccountDAL();
        public List<Account> GetAllAccount()
        {
            return AccountDAL.GetAllAccount();
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
            if (AccountDAL.AddNewAccount(account))
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
            if (AccountDAL.UpdateAccount(account))
            {
                return true;
            }
            else
                return false;
        }
    }
}
