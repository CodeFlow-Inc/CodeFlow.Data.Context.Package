using CodeFlow.Data.Context.Package.Configuration;
using CodeFlow.Data.Context.Package.Tracking;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;

namespace CodeFlow.Data.Context.Package.Base.Context;

public class BaseIdentityDbContex<TUser, TRole, TKey>(
    DbContextOptions options) : IdentityDbContext<TUser, TRole, TKey>(options)
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
{
    public DbSet<CommandFailure> CommandFailures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new CommandFailureConfiguration());
    }
}
