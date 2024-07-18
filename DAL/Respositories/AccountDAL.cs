using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class AccountDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Account> GetAllAccount()
        {
            return db.Accounts.ToList();
        }
        public bool AddNewAccount(Account account)
        {
            try
            {
                db.Accounts.Add(account);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateAccount(Account account)
        {
            try
            {
                var current = GetAllAccount().FirstOrDefault(c => c.Idaccount == account.Idaccount);
                if (current != null)
                {
                    current.PassAccount = account.PassAccount;
                    current.AccountName = account.AccountName;
                    current.Email = account.Email;
                    current.AccountLevel = account.AccountLevel;
                    current.AccountStatus = account.AccountStatus;
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
