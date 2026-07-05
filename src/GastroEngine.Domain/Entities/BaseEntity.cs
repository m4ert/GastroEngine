namespace GastroEngine.Domain.Entities;

public abstract record BaseEntity
{
    public required Guid Id { get; init; }
    
    public required Guid CreatedByUser { get;  init; }
    public required Guid ModifiedByUser { get;  init; }
    
    public required DateTimeOffset CreationDate { get; init; } =  DateTimeOffset.Now;
    public required DateTimeOffset ModificationDate { get; init; } =  DateTimeOffset.Now;
}
