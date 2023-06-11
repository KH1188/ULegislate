using Microsoft.EntityFrameworkCore;

public class test_DbContext : DbContext
{
    public test_DbContext(DbContextOptions<test_DbContext> options) : base(options)
    {
    }

    // Define DbSet properties for your entities
    public DbSet<FileId> FileId { get; set; }
    public DbSet<FileName> FileName { get; set; }
    public DbSet<FilePath> FilePath { get; set; }
    public DbSet<Metadata> Metadata { get; set; }
    public DbSet<Status> Status { get; set; }
    // Add other DbSet properties as needed
}
