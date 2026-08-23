namespace GastroEngine.Domain.Entities;

public record ProductProcessEntity : BaseEntity
{
    public required string Name { get; init; }
    public required decimal DurationInSeconds { get; init; }
    public required decimal DifficultyLevel { get; init; }
}