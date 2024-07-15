using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Respositories;
using DAL.Models;

namespace BUS.Services
{
    public class ProductBUS
    {
        ProductDAL ProductDAL = new ProductDAL();
        ProductDetailDAL ProductDetailDAL = new DAL.Respositories.ProductDetailDAL();
        ProductColorDAL productColorDAL = new ProductColorDAL();  
        public Product GetProductByID(string id)
        {
            return ProductDAL.GetAllProduct().FirstOrDefault(c => c.Idproduct == id);
        }
        public List<Product> GetProductsByName(string name)
        {
            return ProductDAL.GetAllProduct().Where(c => c.ProductName.Contains(name)).ToList();
        }
        public List<Product> GetProducstsByProductCompany(string productCompany)
        {
            return ProductDAL.GetAllProduct().Where(c => c.IdcompanyNavigation.CompanyName == productCompany).ToList();
        }
        public List<Product> GetProductsByCPU(string cpu)
        {
            return ProductDAL.GetAllProduct().Where(c => c.IdcpuNavigation.NameCpu == cpu).ToList();
        }
        public List<Product> GetProductByRameSize(int from, int to)
        {
            return ProductDAL.GetAllProduct().Where(c => c.Ram <= to && c.Ram >= from).ToList();
        }
        public List<Product> GetProductByScreenSize(int from, int to)
        {
            return ProductDAL.GetAllProduct().Where(c => c.ScreenSize <= to && c.ScreenSize >= from).ToList();
        }
        public List<ProductColor> GetAllColorOfProduct(string ID)
        {
            List<ProductDetail> listProductDetail = ProductDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == ID).ToList();
            List<DAL.Models.ProductColor> listColor = new List<DAL.Models.ProductColor>();
            foreach (var productDetail in listProductDetail)
            {
                listColor.Add(productColorDAL.GetAllColor().FirstOrDefault(c => c.Idcolor == productDetail.Idcolor));
            }
            return listColor.Distinct().ToList();
        }
    }
}
