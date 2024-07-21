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
    public class LoginBLL
    {
        LoginDAL account = new LoginDAL();
        
        public bool KiemTraTKMK(string Tentk, string mk)
        {
            Account tg = account.TimkiemTK(Tentk);
            if (tg != null)
            {
                if (tg.PassAccount == mk)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public Account TimkiemTK(string tentk)
        {
            return account.TimkiemTK(tentk);
        }
    }
}
