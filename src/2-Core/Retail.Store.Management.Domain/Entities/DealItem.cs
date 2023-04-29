namespace Retail.Store.Management.Domain.Entities;

public sealed class DealItem
{
    public uint Quantity { get; private set; }
    public decimal Price { get; private set; }
}

// The Id will be a composite key (GoodsId & DealId & Quantity)