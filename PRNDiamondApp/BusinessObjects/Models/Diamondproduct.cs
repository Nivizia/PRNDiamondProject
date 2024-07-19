using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Diamondproduct
{
    public Guid ProductId { get; set; }

    public string? ProductType { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }

    public string? Shape { get; set; }

    public string? CaratWeight { get; set; }

    public string? Color { get; set; }

    public string? Clarity { get; set; }

    public string? Cut { get; set; }

    public string? ProductStatus { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; set; } = new List<Orderitem>();
}
