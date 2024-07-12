using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Cpu
{
    public string Idcpu { get; set; } = null!;

    public string NameCpu { get; set; } = null!;

    public string Manufacturer { get; set; } = null!;

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
