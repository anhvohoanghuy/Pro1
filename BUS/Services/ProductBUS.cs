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
        ProductDAL productDAL = new ProductDAL();
        ProductDetailDAL productDetailDAL = new DAL.Respositories.ProductDetailDAL();
        ProductColorDAL productColorDAL = new ProductColorDAL();
        public List<Product> GetAllProduct()
        {
            return productDAL.GetAllProduct();
        }
        public Product GetProductByID(string id)
        {
            return productDAL.GetAllProduct().FirstOrDefault(c => c.Idproduct == id);
        }
        public bool CheckProductIfExist(string idProduct)
        {
            var check= GetProductByID(idProduct);
            if (check != null)
                return false;
            return true;
        }
        public bool AddNewProduct(string idProduct, string productImage, string productName, string idCompany, int ram,string idCPU, double screenSize, string screenResolution, int refeshRate, double cameraResolution,int pin, string idAccount,bool productStatus)
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
            if (productDAL.AddNewProduct(product))
            {
                return true;
            }
            else
                return false;
        }
        public bool UpdateProduct(string idProduct, string productImage, string productName, string idCompany, int ram, string idCPU, double screenSize, string screenResolution, int refeshRate, double cameraResolution, int pin, string idAccount, bool productStatus)
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
            if (productDAL.UpdateProduct(product))
            {
                return true;
            }
            else
                return false;
        }
        public List<Product> GetProductsByName(string name)
        {
            return productDAL.GetAllProduct().Where(c => c.ProductName.Contains(name)).ToList();
        }
        public List<Product> GetProducstsByProductCompany(string productCompany)
        {
            return productDAL.GetAllProduct().Where(c => c.IdcompanyNavigation.CompanyName == productCompany).ToList();
        }
        public List<Product> GetProductsByCPU(string cpu)
        {
            return productDAL.GetAllProduct().Where(c => c.IdcpuNavigation.NameCpu == cpu).ToList();
        }
        public List<Product> GetProductByRameSize(int from, int to)
        {
            return productDAL.GetAllProduct().Where(c => c.Ram <= to && c.Ram >= from).ToList();
        }
        public List<Product> GetProductByScreenSize(int from, int to)
        {
            return productDAL.GetAllProduct().Where(c => c.ScreenSize <= to && c.ScreenSize >= from).ToList();
        }
        public List<ProductColor> GetAllColorOfProduct(Product current)
        {
            List<ProductDetail> listProductDetail = productDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == current.Idproduct).ToList();
            List<DAL.Models.ProductColor> listColor = new List<DAL.Models.ProductColor>();
            foreach (var productDetail in listProductDetail)
            {
                listColor.Add(productColorDAL.GetAllColor().FirstOrDefault(c => c.Idcolor == productDetail.Idcolor));
            }
            return listColor.Distinct().ToList();
        }
        public List<int> GetAllStorageOfProduct(Product current)
        {
            List<ProductDetail> listProductDetail = productDetailDAL.GetAllProductDetail().Where(c => c.Idproduct == current.Idproduct).ToList();
            List<int> listStorage = new List<int>();
            foreach (var productDetail in listProductDetail)
            {
                listStorage.Add(productDetail.Storage);
            }
            listStorage.Sort();
            return listStorage.Distinct().ToList();
        }
        public List<string> GetAllIDProduct()
        {
            var listProduct= GetAllProduct();
            var listIDProduct = new List<string>();
            foreach (var product in listProduct)
            {
                listIDProduct.Add(product.Idproduct);
            }
            return listIDProduct;
        }
    }
}
