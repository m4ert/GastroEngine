namespace GastroEngine.Domain.Entities;

public record ProductStockEntity : BaseEntity
{
    public required string Name { get; init; }
}