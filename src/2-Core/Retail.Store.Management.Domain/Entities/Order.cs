namespace Retail.Store.Management.Domain.Entities;

public sealed class Order: BaseAuditableEntity<OrderId>
{
    public decimal Total { get; private set; }
}

public readonly record struct OrderId(int Id);