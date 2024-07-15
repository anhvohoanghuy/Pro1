using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Account
{
    public string Idaccount { get; set; } = null!;

    public string PassAccount { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int AccountLevel { get; set; }

    public virtual ICollection<Cpu> Cpus { get; set; } = new List<Cpu>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual ICollection<Imei> Imeis { get; set; } = new List<Imei>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ProductColor> ProductColors { get; set; } = new List<ProductColor>();

    public virtual ICollection<ProductCompany> ProductCompanies { get; set; } = new List<ProductCompany>();

    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<Promotion> Promotions { get; set; } = new List<Promotion>();

    public virtual ICollection<Voucher> Vouchers { get; set; } = new List<Voucher>();
}
