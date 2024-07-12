using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Promotion
{
    public string Idpromotion { get; set; } = null!;

    public string PromotionName { get; set; } = null!;

    public decimal Discount { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
}
