using EfCodeFirst.DataAccess.Models;
using EfCodeFirst.DataAccess.Seeds;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst.DataAccess;

public class MoviesContext : DbContext
{
    public DbSet<Gender> Genders { get; set; }
    public DbSet<Person> Persons { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieCast> MovieCasts { get; set; }
    public DbSet<MovieCrew> MovieCrews { get; set; }
    public DbSet<Department> Departments { get; set; }

    public MoviesContext()
    { }

    public MoviesContext(DbContextOptions<MoviesContext> options)
        : base(options)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(Constants.ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gender>(gender =>
        {
            gender.HasMany(g => g.Persons)
                .WithOne(p => p.Gender)
                .HasForeignKey(p => p.GenderId)
                .OnDelete(DeleteBehavior.Cascade);

            gender.HasData(GenderSeed.Genders);
        });

        modelBuilder.Entity<Person>(person =>
        {
            person.HasMany(p => p.MovieCasts)
                .WithOne(mc => mc.Person)
                .HasForeignKey(mc => mc.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
            person.HasMany(p => p.MovieCrews)
                .WithOne(mc => mc.Person)
                .HasForeignKey(mc => mc.PersonId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Movie>(movie =>
        {
            movie.HasMany(p => p.MovieCasts)
                .WithOne(mc => mc.Movie)
                .HasForeignKey(mc => mc.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            movie.HasMany(p => p.MovieCrews)
                .WithOne(mc => mc.Movie)
                .HasForeignKey(mc => mc.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            movie.HasMany(p => p.MovieLanguages)
                .WithOne(ml => ml.Movie)
                .HasForeignKey(ml => ml.MovieId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<MovieCast>()
            .HasKey(mc => new { mc.MovieId, mc.PersonId });

        modelBuilder.Entity<MovieCrew>()
            .HasKey(mc => new { mc.MovieId, mc.PersonId, mc.DepartmentId });

        modelBuilder.Entity<MovieLanguages>()
            .HasKey(ml => new { ml.MovieId, ml.LanguageId });

        modelBuilder.Entity<Department>(department =>
        {
            department.HasMany(p => p.MovieCrews)
                .WithOne(mc => mc.Department)
                .HasForeignKey(mc => mc.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            department.HasData(DepartmentSeed.Departments);
        });

        modelBuilder.Entity<Language>(language =>
        {
            language.HasMany(p => p.MovieLanguages)
                .WithOne(ml => ml.Language)
                .HasForeignKey(ml => ml.LanguageId)
                .OnDelete(DeleteBehavior.Cascade);

            language.HasData(LanguageSeed.Languages);
        });
    }
}
