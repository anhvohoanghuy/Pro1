using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Respositories
{
    public class PromotionDAL
    {
        Pro1QuanLiDienThoaiFinalContext db = new Pro1QuanLiDienThoaiFinalContext();
        public List<Promotion> GetAllPromotion()
        {
            return db.Promotions.ToList();
        }
        public bool AddNewPromotion(Promotion promotion)
        {
            try
            {
                db.Promotions.Add(promotion);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdatePromotion(Promotion promotion)
        {
            try
            {
                var current=db.Promotions.FirstOrDefault(c=>c.Idpromotion==promotion.Idpromotion);
                if (current != null) 
                {
                    current.PromotionName = promotion.PromotionName;
                    current.Discount=promotion.Discount;
                    current.StartTime=promotion.StartTime;
                    current.EndTime=promotion.EndTime;
                    current.Idaccount = promotion.Idaccount;
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
