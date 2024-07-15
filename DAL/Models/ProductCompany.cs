using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductCompany
{
    public string Idcompany { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
