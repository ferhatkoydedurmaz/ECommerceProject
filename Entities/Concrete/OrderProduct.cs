﻿namespace Entities.Concrete;
public class OrderProduct
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int ProductVariantId { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }
    public double Price { get; set; }
}
