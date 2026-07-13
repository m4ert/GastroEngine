namespace GastroEngine.Domain.Entities;

public abstract record PersonEntity : BaseEntity
{
    public required string Name { get; init; }
    public required string LastName { get; init; }
}