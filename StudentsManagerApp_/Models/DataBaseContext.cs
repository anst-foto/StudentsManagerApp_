using Microsoft.EntityFrameworkCore;

namespace StudentsManagerApp_.Models;

public class DataBaseContext : DbContext
{
    private const string ConnectionString = 
        "Server=127.0.0.1;Port=5432;Database=students_db;User Id=postgres;Password=1234;";
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Mark> Marks { get; set; }

    public DataBaseContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(ConnectionString);
    }
}