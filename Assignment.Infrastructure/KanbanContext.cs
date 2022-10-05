using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Infrastructure;

public class KanbanContext : DbContext
{
    public KanbanContext(DbContextOptions<KanbanContext> options)
            : base(options)
        {
        }
    
    public DbSet<User> Users {get; set;}
    public DbSet<Tag> Tags {get; set;}
    public DbSet<WorkItem> WorkItems {get; set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<WorkItem>()
            .HasOne(w => w.AssignedTo)
            .WithMany(u => u.WorkItems);

        modelBuilder.Entity<Tag>()
            .HasIndex(t => t.Name)
            .IsUnique();

        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        
    }
}
