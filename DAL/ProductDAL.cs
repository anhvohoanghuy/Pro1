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

    }
}
