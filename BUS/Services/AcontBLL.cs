using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL;
using DAL.Models;

namespace BUS.Services
{
    public class AcontBLL
    {
        LoginBLL loginBLL = new LoginBLL();
        AcontDAL acontDAL = new AcontDAL();
        List<Account> List;
        public List<Account> getListAccount()
        {
          
          List=acontDAL.list();
            return List;
        }
        public bool AddTaiKhoan(Account account)
        {
            if (loginBLL.TimkiemTK(account.Idaccount) == null)
            {
                acontDAL.AddTaiKhoan(account);
                return true;
            }
            return false;
        }
        public bool DeleteTaiKhoan(string account)
        {
            if (loginBLL.TimkiemTK(account) != null)
            {
                acontDAL.DeleteTaiKhoan(loginBLL.TimkiemTK(account));
                return true;
            }
            return false;
        }
        public void Replace(Account nv)
        {
            List = acontDAL.list();
            if (List.Find(p => p.Idaccount == nv.Idaccount) != null)
            {
                acontDAL.Replace(nv);

            }

        }

    }
}
