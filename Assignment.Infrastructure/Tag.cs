namespace Assignment.Infrastructure;

public class Tag
{
    public int Id {get; set;}
    
    public string Name {get; set;}

    [Required]
    [MaxLength(50)]
    public IEnumerable<WorkItem> WorkItems {get; set;}
}
