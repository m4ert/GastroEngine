namespace GastroEngine.Domain.Entities;

public record ProductEntity : BaseEntity
{
    public required string Name { get; init; }
    public required UInt32 Quantity { get; init; }
}