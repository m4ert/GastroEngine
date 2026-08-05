using GastroEngine.Domain.Enums;

namespace GastroEngine.Domain.Entities;

public record ProductPreparationEntity : BaseEntity
{
    public required Int32 Index { get; init; }
    public required UInt64 ProductId { get; init; }
    public required string Name { get; init; }
    public required UnitOfMeasure Unit { get; init; }
    public required decimal TotalUnits { get; init; }
    public required decimal DurationInSeconds { get; init; }
}