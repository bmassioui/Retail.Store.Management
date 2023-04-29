namespace Retail.Store.Management.Domain.Entities;

public sealed class Store: BaseAuditableEntity<StoreId>
{
    public string? Address { get; private set; }
}

public readonly record struct StoreId(int Id);