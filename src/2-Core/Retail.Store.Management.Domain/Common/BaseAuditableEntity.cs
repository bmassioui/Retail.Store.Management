namespace Retail.Store.Management.Domain.Common;

public abstract class BaseAuditableEntity<TId> : BaseEntity<TId> where TId : struct, IEquatable<TId>
{
    public DateTime CreatedAt { get; set; }

    public TId? CreatedBy { get; set; }

    public DateTime? LastModifiedAt { get; set; }

    public TId? LastModifiedBy { get; set; }
}
