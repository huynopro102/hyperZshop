using System;
using System.Collections.Generic;

namespace DoAnWeb.Model;

public partial class Warehousedetail
{
    public int Idwarehouse { get; set; }

    public int Idproduct { get; set; }

    public int QuantityInStock { get; set; }

    public virtual Product IdproductNavigation { get; set; } = null!;

    public virtual Warehouse IdwarehouseNavigation { get; set; } = null!;
}
