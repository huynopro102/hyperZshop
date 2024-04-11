using System;
using System.Collections.Generic;

namespace DoAnWeb.Model;

public partial class Customer
{
    public int Idcustomer { get; set; }

    public string Username { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string PhoneCustomer { get; set; } = null!;

    public string CustomerAddress { get; set; } = null!;

    public string CitizenIdentificationCode { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public int Sex { get; set; }

    public int? IdImages { get; set; }

    public virtual Image? IdImagesNavigation { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();

    public virtual User UsernameNavigation { get; set; } = null!;
}
