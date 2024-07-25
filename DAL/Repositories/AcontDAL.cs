using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class AcontDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Account> list()
        {
            return db.Accounts.ToList<Account>();
        }
        public void AddTaiKhoan(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void DeleteTaiKhoan(Account account)
        {
            db.Accounts.Remove(account);
            db.SaveChanges();
        }
        public List<Account> InsertAC(string Keyword)
        {
            List<Account> listTG = db.Accounts.Where(s => s.Idaccount.Contains(Keyword) || s.PassAccount.Contains(Keyword) || s.AccountName.Contains(Keyword) || s.Email.Contains(Keyword) || s.AccountLevel.ToString().Contains(Keyword)).ToList();
            return listTG;

        }
        public void Replace(Account nvNew)
        {
            Account nvTG = db.Accounts.FirstOrDefault(p => p.Idaccount == nvNew.Idaccount);
            if (nvTG != null)
            {
                nvTG.PassAccount = nvNew.PassAccount;
                nvTG.AccountName = nvNew.AccountName;
                nvTG.Email = nvNew.Email;
                nvTG.AccountLevel = nvNew.AccountLevel;
                db.SaveChanges();
            }
        }
    }
}
