namespace Assignment.Infrastructure;

public class User
{
    public int Id {get; set;}
    
    [Required]
    [MaxLength(100)]
    public string Name {get; set;}

    [Required]
    [MaxLength(100)]
    public string Email {get; set;}

    public IEnumerable<WorkItem> WorkItems {get; set;}
}
