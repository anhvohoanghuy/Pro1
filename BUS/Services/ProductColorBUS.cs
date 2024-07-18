using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ProductColorBUS
    {
        ProductColorDAL productColorDAL=new ProductColorDAL();
        public List<ProductColor> GetAllColor()
        {
            return productColorDAL.GetAllColor();
        }
        public bool AddNewColor(string idColor, string  colorName, string idAccount)
        {
            ProductColor productColor = new ProductColor()
            {
                Idcolor = idColor,
                ColorName = colorName,
                Idaccount = idAccount
            };
            if(productColorDAL.AddNewColor(productColor))
                 return true;
            else
                return false;
        }
        public bool UpdateProductColor(string idColor, string colorName, string idAccount)
        {
            ProductColor productColor = new ProductColor()
            {
                Idcolor = idColor,
                ColorName = colorName,
                Idaccount = idAccount
            };
            if(productColorDAL.UpdateColor(productColor))
                return true;
            else
                return false;
        }
    }
}
