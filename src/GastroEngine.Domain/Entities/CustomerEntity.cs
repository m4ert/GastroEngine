using System.ComponentModel.DataAnnotations;

namespace GastroEngine.Domain.Entities;

public record CustomerEntity : PersonEntity
{
    [Phone]
    public string? PhoneNumber { get; init; }
    
    [EmailAddress]
    public string? EmailAddress { get; init; }
}