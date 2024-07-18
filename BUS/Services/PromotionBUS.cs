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
        PromotionDAL PromotionDAL = new PromotionDAL();
        public List<Promotion> GetAllPromotion()
        {
            return PromotionDAL.GetAllPromotion();
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
            if(PromotionDAL.AddNewPromotion(promotion))
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
            if (PromotionDAL.UpdatePromotion(promotion))
                return true;
            else
                return false;
        }
    }
}
