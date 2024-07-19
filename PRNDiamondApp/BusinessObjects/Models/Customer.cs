﻿using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Customer
{
    public Guid CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
