using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class ProductDetailDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<ProductDetail> GetAllProductDetail()
        { return db.ProductDetails.ToList(); }
        public bool AddNewProductDetail(ProductDetail productDetail)
        {
            try
            {
                db.ProductDetails.Add(productDetail);
                db.SaveChanges();
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateProductDetail(ProductDetail productDetail)
        {
            try
            {
                var currentProductDetail=db.ProductDetails.FirstOrDefault(c=>c.IdproductDetails==productDetail.Idproduct);
                if (currentProductDetail != null)
                {
                    currentProductDetail.Idproduct=productDetail.IdproductDetails;
                    currentProductDetail.Idcolor=productDetail.Idcolor;
                    currentProductDetail.Storage=productDetail.Storage;
                    currentProductDetail.Price=productDetail.Price;
                    currentProductDetail.Idpromotion=productDetail.Idpromotion;
                    currentProductDetail.WarrantyPeriod=productDetail.WarrantyPeriod;
                    currentProductDetail.Inventory=productDetail.Inventory;
                    currentProductDetail.Idaccount=productDetail.Idaccount;
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
