using DAL.Models;
using DAL.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class PromotionBUS
    {
        PromotionDAL promotionDAL = new PromotionDAL();
        public List<Promotion> GetAllPromotion()
        {
            return promotionDAL.GetAllPromotion();
        }
        public List<string> GetAllIdPromotion()
        {
            var listPromotion= GetAllPromotion();
            var listID= new List<string>();
            foreach (var id in listPromotion)
            {
                listID.Add(id.Idpromotion);
            }
            return listID;
        }
        public bool AddNewPromotion(string idPromotion,string promotionName, decimal discount, DateTime startTime, DateTime endTime,string idAccount)
        {
            Promotion promotion = new Promotion()
            {
                Idpromotion = idPromotion,
                PromotionName = promotionName,
                Discount = discount,
                StartTime = startTime,
                EndTime = endTime,
                Idaccount = idAccount
            };
            if(promotionDAL.AddNewPromotion(promotion))
                return true;
            else
                return false;
        }
        public bool UpdatePromotion(string idPromotion, string promotionName, decimal discount, DateTime startTime, DateTime endTime, string idAccount)
        {
            Promotion promotion = new Promotion()
            {
                Idpromotion = idPromotion,
                PromotionName = promotionName,
                Discount = discount,
                StartTime = startTime,
                EndTime = endTime,
                Idaccount = idAccount
            };
            if (promotionDAL.UpdatePromotion(promotion))
                return true;
            else
                return false;
        }
        public Promotion GetPromotionById(string idPromotion) 
        {
            return GetAllPromotion().FirstOrDefault(c=>c.Idpromotion==idPromotion);
        }
    }
}
