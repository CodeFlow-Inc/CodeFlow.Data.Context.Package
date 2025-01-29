using CodeFlow.Data.Context.Package.Configuration;
using CodeFlow.Data.Context.Package.Tracking;
using Microsoft.EntityFrameworkCore;

namespace CodeFlow.Data.Context.Package.Base.Context;

public class BaseDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<CommandFailure> CommandFailures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CommandFailureConfiguration());
    }
}
