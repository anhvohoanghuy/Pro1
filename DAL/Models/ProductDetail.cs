using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ProductDetail
{
    public string Idproduct { get; set; } = null!;

    public string IdproductDetails { get; set; } = null!;

    public string Idcolor { get; set; } = null!;

    public int Storage { get; set; }

    public decimal Price { get; set; }

    public string? Idpromotion { get; set; }

    public int WarrantyPeriod { get; set; }

    public int Inventory { get; set; }

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual Color IdcolorNavigation { get; set; } = null!;

    public virtual Product IdproductNavigation { get; set; } = null!;

    public virtual Promotion? IdpromotionNavigation { get; set; }

    public virtual ICollection<Imei> Imeis { get; set; } = new List<Imei>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
