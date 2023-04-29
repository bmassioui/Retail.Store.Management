namespace Retail.Store.Management.Domain.Entities;

public sealed class Goods: BaseAuditableEntity<GoodsId>
{
    public required string Name { get; init; } 
    public decimal UnitPrice { get; private set; }
}

public readonly record struct GoodsId(Guid Id);