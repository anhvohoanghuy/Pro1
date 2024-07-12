using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Customer
{
    public string Idcustomer { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? CustomerAddress { get; set; }

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
