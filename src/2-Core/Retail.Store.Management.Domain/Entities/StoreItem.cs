namespace Retail.Store.Management.Domain.Entities;

public sealed class StoreItem
{
    public uint Quantity { get; init; }
    public decimal UnitPrice { get; private set; }
}


// The Id will be a composite key (GoodsId & StoreId)