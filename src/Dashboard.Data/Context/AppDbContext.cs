using Dashboard.Business.Models;
using Dashboard.Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Team> Team { get; set; }
    public DbSet<Employee> Employee { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.SeedTeam();
        modelBuilder.SeedEmployee();
    }
}