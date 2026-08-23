namespace GastroEngine.Domain.Entities;

public record ProductRecipeStepEntity : BaseEntity
{
    public required UInt32 ProductId  { get; init; }
    public required UInt32? RequiredStepId { get; init; }
    public required UInt32 ProcessId { get; init; }
    public required bool AllowParallelism { get; init; }
}