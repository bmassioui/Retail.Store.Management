namespace Retail.Store.Management.Domain.Entities;

public sealed class Deal: BaseAuditableEntity<DealId>
{
    public decimal Total { get; private set; }
}

public readonly record struct DealId(uint Id);