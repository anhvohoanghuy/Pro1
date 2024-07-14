using DAL.Models;

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
            return GetAllProduct().Where(c=>c.)
        }
            
    }
}
