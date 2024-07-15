using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ProductColorDAL
    {
        Pro1QuanLiDienThoaiFinalContext db= new Pro1QuanLiDienThoaiFinalContext();
        public List<ProductColor> GetAllColor()
        {
            return db.ProductColors.ToList();
        }
    }
}
