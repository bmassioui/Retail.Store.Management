namespace Retail.Store.Management.Domain.Entities;

public sealed class OrderItem
{
    public uint Quantity { get; init; }
    public decimal Price { get; private set; }
}

// The Id will be a composite key (GoodsId & OrderId & Quantity)