using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Order
{
    public string Idorder { get; set; } = null!;

    public string? Idaccount { get; set; }

    public string Idcustomer { get; set; } = null!;

    public DateTime EstablishedDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string? Idvorcher { get; set; }

    public bool? Paid { get; set; }

    public virtual Account? IdaccountNavigation { get; set; }

    public virtual Customer IdcustomerNavigation { get; set; } = null!;

    public virtual Voucher? IdvorcherNavigation { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
