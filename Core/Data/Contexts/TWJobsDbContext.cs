using Microsoft.EntityFrameworkCore;
using TwJobs.Core.Data.EntityConfigs;
using TWJobs.Core.Models;

namespace TWJobs.Core.Data.Contetxs;

public class TWJobsDbContext : DbContext
{
    public DbSet<Job> jobs => Set<Job>();
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
         builder.UseSqlServer("Server=Localhost;Database=TWJobs;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new jobEntityConfig());
    }
}