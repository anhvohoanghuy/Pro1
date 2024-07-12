using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class OrderDetail
{
    public string Idorder { get; set; } = null!;

    public string IdproductDetails { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Amount { get; set; }

    public decimal ReducedAmount { get; set; }

    public virtual Order IdorderNavigation { get; set; } = null!;

    public virtual ProductDetail IdproductDetailsNavigation { get; set; } = null!;
}
