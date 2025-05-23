using System;

namespace Domain;

public class BaseEntity
{

    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime DeletedAt { get; set; }

}
