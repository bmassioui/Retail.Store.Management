namespace Retail.Store.Management.Domain.Entities;

public sealed class Supplier: BaseAuditableEntity<SupplierId>
{
    public required string FullName { get; init; }
    public string? Address { get; private set; }
    public string? CompanyName { get; private set; }
    public string? WebSite { get; private set; }
    public string? Phone { get; private set; }
}

public readonly record struct SupplierId(Guid Id);