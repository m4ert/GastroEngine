namespace GastroEngine.Domain.Entities;

public record ChefEntity : PersonEntity
{
    public required ushort ExperienceLevel { get; init; }
}