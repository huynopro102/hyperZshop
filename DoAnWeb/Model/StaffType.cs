﻿using System;
using System.Collections.Generic;

namespace DoAnWeb.Model;

public partial class StaffType
{
    public int IdstaffType { get; set; }

    public string StaffTypeName { get; set; } = null!;

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
