namespace Assignment.Infrastructure;

public class WorkItem
{
    public int Id {get; set;}

    [Required]
    [MaxLength(100)]
    public string Title {get; set;}

    public User? AssignedTo {get; set;}

    public string? Description {get; set;}

    [Required]
    public State State {get; set;}
    
    public IEnumerable<Tag> Tags {get; set;}
}
