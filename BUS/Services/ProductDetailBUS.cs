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
        public List<ProductDetail> GetAllProductDetail()
        {
            return ProductDetailDAL.GetAllProductDetail();
        }
        public decimal GetPriceOfProductDetail(ProductDetail productDetail)
        {
            return productDetail.Price;
        }
        public bool AddNewProductDetail(string idProduct,string idProductDetail, string idColor,int storage, decimal price, string idPromotion, int wrrantyPeriod, int inventory, string idAccount)
        {
            ProductDetail productDetail = new ProductDetail()
            {
                Idproduct = idProduct,
                IdproductDetails = idProductDetail,
                Idcolor = idColor,
                Storage = storage,
                Price = price,
                Idpromotion = idPromotion,
                WarrantyPeriod = wrrantyPeriod,
                Inventory = inventory,
                Idaccount = idAccount
            };
            if (ProductDetailDAL.AddNewProductDetail(productDetail))
                return true;
            else 
                return false;
        }
        public bool UpdateProductDetail(string idProduct, string idProductDetail, string idColor, int storage, decimal price, string idPromotion, int wrrantyPeriod, int inventory, string idAccount)
        {
            ProductDetail productDetail = new ProductDetail()
            {
                Idproduct = idProduct,
                IdproductDetails = idProductDetail,
                Idcolor = idColor,
                Storage = storage,
                Price = price,
                Idpromotion = idPromotion,
                WarrantyPeriod = wrrantyPeriod,
                Inventory = inventory,
                Idaccount = idAccount
            };
            if (ProductDetailDAL.UpdateProductDetail(productDetail))
                return true;
            else
                return false;
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
