using System.ComponentModel.DataAnnotations;

namespace GastroEngine.Domain.Entities;

public record ChefEntity : PersonEntity
{
    
    [Range(1, 100)]
    public required ushort ExperienceLevel { get; init; }
}