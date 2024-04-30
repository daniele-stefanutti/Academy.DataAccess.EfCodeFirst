using EfCodeFirst.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst.DataAccess;

public class MoviesContext : DbContext
{
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Person> Persons { get; set; }

    public MoviesContext()
    { }

    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Constants.ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gender>()
            .HasMany(g => g.Persons)
            .WithOne(p => p.Gender)
            .HasForeignKey(p => p.GenderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
