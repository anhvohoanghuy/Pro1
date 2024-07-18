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
        public bool AddNewColor(ProductColor productColor)
        {
            try
            {
                db.ProductColors.Add(productColor);
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }
        public bool UpdateColor(ProductColor productColor)
        {
            try
            {
                var current= db.ProductColors.FirstOrDefault(c=>c.Idcolor==productColor.Idcolor);
                if (current != null) 
                {
                    current.ColorName=productColor.ColorName;
                    current.Idaccount=productColor.Idaccount;
                    db.SaveChanges();
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
