using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ProductDetailDAL
    {
        Pro1QuanLiDienThoaiFinalContext db=new Pro1QuanLiDienThoaiFinalContext();
        public List<ProductDetail> GetAllProductDetail()
        { return db.ProductDetails.ToList(); }

    }
}
