namespace GastroEngine.Domain.Entities;

public abstract record BaseEntity
{
    public required UInt64 Id { get; init; }
    
    public required UInt64 CreatedByUser { get;  init; }
    public required UInt64 ModifiedByUser { get;  init; }
    
    public required DateTimeOffset CreationDate { get; init; } =  DateTimeOffset.Now;
    public required DateTimeOffset ModificationDate { get; init; } =  DateTimeOffset.Now;
}
