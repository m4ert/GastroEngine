using GastroEngine.Domain.Enums;

namespace GastroEngine.Domain.Entities;

public record ProductStockTransactionEntity
{
    public required UInt64 Id { get; init; }
    public required UInt32 ProductStockId { get;  init; }
    public required UInt32? ProcessDetailId { get; init; }
    public required MeasureUnit MeasureUnit { get; init; }
    public required decimal TotalUnits { get;  init; }
    public required StockMovement MovementType { get; init; }
    public required DateTimeOffset CreationDate { get; init; } = DateTimeOffset.UtcNow;
}