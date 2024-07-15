using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Voucher
{
    public string Idvoucher { get; set; } = null!;

    public string VoucherName { get; set; } = null!;

    public decimal Discount { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
