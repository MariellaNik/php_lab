using Microsoft.EntityFrameworkCore;
using WebApplication13.Models.DAL;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    //public DbSet<WebApplication13.Models.DAL.Course> Course { get; set; } = default!;
    public DbSet<Course> Course { get; set; }
    public DbSet<Major> Major { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Major>().HasData(
        new Major() { Id = 1, Name = "Computer Science" },
        new Major() { Id = 2, Name = "Information Systems" }
        );
        modelBuilder.Entity<Course>().HasData(
        new Course()
        {
            Id = 1,
            MajorId = 1,
            Name = "COS 120",
            Description = "C++ Programming"
        },
        new Course()
        {
            Id = 2,
            MajorId = 1,
            Name = "COS 340",
            Description = "Python Programming"
        },
        
        new Course() 
        { 
            Id = 3, 
            MajorId = 2, 
            Name = "INF 130", 
            Description = "C# Programming" 
        }
        );
    }
}
