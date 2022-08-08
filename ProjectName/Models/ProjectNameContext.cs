using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<CLassOne> ClassOnes { get; set; }
    public DbSet<ClassTwo> ClassTwos { get; set; }
    public DbSet<ClassOneClassTwo> ClassOneClassTwo { get;  set; }

    public ProjectNameContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}