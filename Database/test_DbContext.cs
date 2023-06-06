using Microsoft.EntityFrameworkCore;

public class test_DbContext : DbContext
{
    public test_DbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    // Define DbSet properties for your entities
    public DbSet<File> Files { get; set; }
    public DbSet<Directory> Directories { get; set; }
    // Add other DbSet properties as needed
}
