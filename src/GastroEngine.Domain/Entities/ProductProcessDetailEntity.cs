using GastroEngine.Domain.Enums;

namespace GastroEngine.Domain.Entities;

public record ProductProcessDetailEntity : BaseEntity
{
    public required UInt32 ProcessId { get; init; }
    public required UInt32 ProductStockId  { get; init; }
    public required MeasureUnit MeasureUnit { get; init; }
    public required decimal TotalUnits { get; init; }
}