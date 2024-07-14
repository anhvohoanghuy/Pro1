using DAL.Models;
using System.Diagnostics.Contracts;

namespace DAL
{
    public class ProductDAL
    {
        Pro1QuanLiDienThoaiFinalContext db= new Pro1QuanLiDienThoaiFinalContext();
        public ProductDAL()
        {
            
        }
        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }
        public bool AddNewProduct(Product newProduct)
        {
            try
            {
                db.Products.Add(newProduct);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        public bool UpdateProduct(string id,string productImage,string productName, string idCompany,int ram, string idCPU,float screenSize, string screenResolution, int refreshRate,float cameraResolution, int pin, string idAcount) 
        {
            try
            {
                var current=GetAllProduct().FirstOrDefault(c=>c.Idproduct==id);
                current.ProductImage=productImage;
                current.ProductName=productName;
                current.Idcompany=idCompany;
                current.Ram=ram;
                current.Idcpu=idCPU;
                current.ScreenSize=screenSize;
                current.ScreenResolution=screenResolution;
                current.RefreshRate=refreshRate;
                current.CameraResolution=cameraResolution;
                current.Pin=pin;
                current.Idaccount=idAcount;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteProduct(Product newProduct) 
        {
            try
            {
                var listProductDetail = db.ProductDetails.Where(p => p.Idproduct == newProduct.Idproduct).ToList();
                foreach (var product in listProductDetail) 
                {
                    db.ProductDetails.Remove(product);
                }
                db.Products.Remove(newProduct);
                db.SaveChanges();
                return true ;
            }
            catch
            {
                return false;
            }
        }
        public Product GetProductByID(string id)
        {
            return db.Products.FirstOrDefault(c=>c.Idproduct==id);
        }
        public List<Product> GetProductsByName(string name)
        {
            return db.Products.Where(c=>c.ProductName.Contains(name)).ToList();
        }
        public List<Product> GetProducstsByProductCompany(string productCompany)
        {
            return GetAllProduct().Where(c=>c.IdcompanyNavigation.CompanyName==productCompany).ToList();
        }
        public List<Product> GetProductsByCPU(string cpu)
        {
            return GetAllProduct().Where(c=>c.IdcpuNavigation.NameCpu==cpu).ToList();
        }
        public List<Product> GetProductByRameSize(int from, int to)
        {
            return GetAllProduct().Where(c=>c.Ram<=to&&c.Ram>=from).ToList();
        }
        public List<Product> GetProductByScreenSize(int from, int to)
        {
            return GetAllProduct().Where(c => c.ScreenSize <= to && c.ScreenSize >= from).ToList();
        }
        public List<Color> GetAllColorOfProduct( string ID) 
        {
            List<ProductDetail> listProductDetail= db.ProductDetails.Where(c=>c.Idproduct==ID).ToList();
            List<Color> listColor = new List<Color>();
            foreach (var productDetail in listProductDetail)
            {
                listColor.Add(db.Colors.FirstOrDefault(c=>c.Idcolor==productDetail.Idcolor));
            }
            return listColor.Distinct().ToList();
        }
    }
}
