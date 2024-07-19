using System;
using System.Collections.Generic;

namespace BusinessObjects.Models;

public partial class Orderitem
{
    public Guid OrderItemId { get; set; }

    public Guid? OrderId { get; set; }

    public Guid? DproductId { get; set; }

    public decimal? Price { get; set; }

    public string? ProductType { get; set; }

    public virtual Diamondproduct? Dproduct { get; set; }

    public virtual Order? Order { get; set; }
}
