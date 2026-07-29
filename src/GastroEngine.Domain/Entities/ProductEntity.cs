namespace GastroEngine.Domain.Entities;

public record ProductEntity : BaseEntity
{
    public required string Name { get; init; }
    public required string? Description { get; init; }
    public required decimal Price { get; init; }
    public required decimal DifficultyLevel { get; init; }
}