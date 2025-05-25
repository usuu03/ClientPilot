

namespace Domain;

public class Client : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string BusinessName { get; set; } = string.Empty;

    public bool HasLeftReview { get; set; } = false;
    public DateTime? LastReviewDate { get; set; }



    // public List<Note> Notes { get; set; } = new();
    // public List<Tag> Tags { get; set; } = new();


}
