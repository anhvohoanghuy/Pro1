using DAL.Models;
using System.Diagnostics.Contracts;

namespace DAL.Respositories
{
    public class ProductDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
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
        public bool UpdateProduct(Product updateProduct)
        {
            try
            {
                var current = GetAllProduct().FirstOrDefault(c => c.Idproduct == updateProduct.Idproduct);
                if (current != null)
                {
                    current.ProductImage = updateProduct.ProductImage;
                    current.ProductName = updateProduct.ProductName;
                    current.Idcompany = updateProduct.Idcompany;
                    current.Ram = updateProduct.Ram;
                    current.Idcpu = updateProduct.Idcpu;
                    current.ScreenSize = updateProduct.ScreenSize;
                    current.ScreenResolution = updateProduct.ScreenResolution;
                    current.RefreshRate = updateProduct.RefreshRate;
                    current.CameraResolution = updateProduct.CameraResolution;
                    current.Pin = updateProduct.Pin;
                    current.Idaccount = updateProduct.Idaccount;
                    current.ProductStatus = updateProduct.ProductStatus;
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
        public bool ChangeStatusProduct(Product updateProduct)
        {
            try
            {
                updateProduct.ProductStatus = false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        
    }
}
