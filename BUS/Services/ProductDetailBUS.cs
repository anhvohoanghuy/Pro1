using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ProductDetailBUS
    {
        ProductDetailDAL ProductDetailDAL = new ProductDetailDAL();
        PromotionDAL PromotionDAL = new PromotionDAL();
        public decimal GetPriceOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.Price;
        }
        public ProductDetail GetProductDetailByIdProductStorageColor(string IdProduct, int storage,string IdColor)
        {
            return ProductDetailDAL.GetAllProductDetail().FirstOrDefault(c => c.Idproduct == IdProduct && c.Storage == storage && c.Idcolor == IdColor);
        }
        public int GetInventoryOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.Inventory;
        }
        public decimal GetDiscountOfProductDetail(ProductDetail productDetail)
        {
            return PromotionDAL.GetAllPromotion().FirstOrDefault(c => c.Idpromotion == productDetail.Idpromotion).Discount;
        }
        public int GetWarrantyPeriodOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.WarrantyPeriod;
        }
    }
}
