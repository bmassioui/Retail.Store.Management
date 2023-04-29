namespace Retail.Store.Management.Domain.Entities;

public sealed class Customer : BaseAuditableEntity<CustomerId>
{
    public required string FullName { get; init; }
    public string? Address { get; private set; }
    public string? Phone { get; private set; }
}

public readonly record struct CustomerId(Guid Id);