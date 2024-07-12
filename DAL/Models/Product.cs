﻿using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Product
{
    public string Idproduct { get; set; } = null!;

    public string ProductImage { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public string ProductCompany { get; set; } = null!;

    public int Ram { get; set; }

    public string Idcpu { get; set; } = null!;

    public double ScreenSize { get; set; }

    public string ScreenResolution { get; set; } = null!;

    public int RefreshRate { get; set; }

    public double CameraResolution { get; set; }

    public int Pin { get; set; }

    public string Idaccount { get; set; } = null!;

    public virtual Account IdaccountNavigation { get; set; } = null!;

    public virtual Cpu IdcpuNavigation { get; set; } = null!;

    public virtual ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();
}
