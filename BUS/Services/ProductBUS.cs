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
        public bool AddNewProduct(string idProduct, string productImage, string productName, string idCompany, int ram,string idCPU, float screenSize, string screenResolution, int refeshRate, float cameraResolution,int pin, string idAccount,bool productStatus)
        {
            Product product = new Product()
            {
                Idproduct= idProduct,
                ProductImage= productImage,
                ProductName= productName,
                Idcompany= idCompany,
                Ram=ram,
                Idcpu=idCPU,
                ScreenSize=screenSize,
                ScreenResolution=screenResolution,
                RefreshRate=refeshRate,
                CameraResolution=cameraResolution,
                Pin=pin,
                Idaccount=idAccount,
            };
            if (ProductDAL.AddNewProduct(product))
            {
                return true;
            }
            else
                return false;
        }
        public bool UpdateProduct(string idProduct, string productImage, string productName, string idCompany, int ram, string idCPU, float screenSize, string screenResolution, int refeshRate, float cameraResolution, int pin, string idAccount, bool productStatus)
        {
            Product product = new Product()
            {
                Idproduct = idProduct,
                ProductImage = productImage,
                ProductName = productName,
                Idcompany = idCompany,
                Ram = ram,
                Idcpu = idCPU,
                ScreenSize = screenSize,
                ScreenResolution = screenResolution,
                RefreshRate = refeshRate,
                CameraResolution = cameraResolution,
                Pin = pin,
                Idaccount = idAccount,
            };
            if (ProductDAL.UpdateProduct(product))
            {
                return true;
            }
            else
                return false;
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
        public List<ProductColor> GetAllColorOfProduct(Product current)
        {
            List<ProductDetail> listProductDetail = ProductDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == current.Idproduct).ToList();
            List<DAL.Models.ProductColor> listColor = new List<DAL.Models.ProductColor>();
            foreach (var productDetail in listProductDetail)
            {
                listColor.Add(productColorDAL.GetAllColor().FirstOrDefault(c => c.Idcolor == productDetail.Idcolor));
            }
            return listColor.Distinct().ToList();
        }
        public List<int> GetAllStorageOfProduct(Product current)
        {
            List<ProductDetail> listProductDetail = ProductDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == current.Idproduct).ToList();
            List<int> listStorage = new List<int>();
            foreach (var productDetail in listProductDetail)
            {
                listStorage.Add(productDetail.Storage);
            }
            listStorage.Sort();
            return listStorage.Distinct().ToList();
        }
    }
}
