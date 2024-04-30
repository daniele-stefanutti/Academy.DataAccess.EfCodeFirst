using EfCodeFirst.DataAccess;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("Application started");

        MoviesContext context = new(new DbContextOptions<MoviesContext>());
        await context.Database.MigrateAsync();
    }
}