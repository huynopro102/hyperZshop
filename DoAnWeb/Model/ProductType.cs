﻿using System;
using System.Collections.Generic;

namespace DoAnWeb.Model;

public partial class ProductType
{
    public int IdproductType { get; set; }

    public string ProductTypeName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
