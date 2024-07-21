using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LoginDAL
    {
        Pro1QuanLiDienThoaiFinalContext db =new Pro1QuanLiDienThoaiFinalContext();

        
       
        public Account TimkiemTK(string tentk)
        {
            return db.Accounts.FirstOrDefault(a => a.Idaccount == tentk);
        }
    }
}
