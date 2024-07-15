using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductColor
{
    public string Idcolor { get; set; } = null!;

    public string? ColorName { get; set; }

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
}
