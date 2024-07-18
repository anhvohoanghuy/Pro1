using BUS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Validate
    {
        ProductBUS productBUS = new ProductBUS();
        ProductCompanyBUS productCompanyBUS = new ProductCompanyBUS();
        public bool CheckProductIfExists(string productId)
        {
            var check = productBUS.GetProductByID(productId);
            if (productId == null)
                return false;
            return true;
        }
        public bool CheckCompanyExists(string idCompany)
        {
            var check = productCompanyBUS.GetCompanyById(idCompany);
            if (check == null)
                return true;
            return false;
        }
        public bool CheckIsInt(string idNumber)
        {
            if (int.TryParse(idNumber, out _))
                return true;
            return false;
        }
        public bool CheckIsFloat(string idNumber)
        {
            if (float.TryParse(idNumber, out _))
                return true;
            return false;
        }
        public bool CheckIsDecimal(string idNumber)
        {
            if (float.TryParse(idNumber, out _))
                return true;
            return false;
        }
    }
}
