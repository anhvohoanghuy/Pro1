using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ProductCompany
    {
        public string Idcompany { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Idaccount { get; set; } = null!;

        public virtual Account IdaccountNavigation { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
