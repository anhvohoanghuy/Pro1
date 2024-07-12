using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Imei
{
    public string IdproductDetails { get; set; } = null!;

    public string ImeiNumber { get; set; } = null!;

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual ProductDetail IdproductDetailsNavigation { get; set; } = null!;
}
