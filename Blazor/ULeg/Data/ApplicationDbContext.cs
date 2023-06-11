using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ULeg.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

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
