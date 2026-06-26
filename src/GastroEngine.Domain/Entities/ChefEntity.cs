using System.ComponentModel.DataAnnotations;

namespace GastroEngine.Domain.Entities;

public record ChefEntity : PersonEntity
{
    public required bool IsEnabled { get; init; }
    
    [Range(1, 100)]
    public required ushort ExperienceLevel { get; init; }
}