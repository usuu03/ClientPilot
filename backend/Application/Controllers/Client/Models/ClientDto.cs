using System;

namespace Application.Controllers.Client.Models;

public class ClientDto
{
    public Guid Id { get; init; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string BusinessName { get; set; } = string.Empty;
    public bool HasLeftReview { get; set; } = false;
    public DateTime? LastReviewDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

}
