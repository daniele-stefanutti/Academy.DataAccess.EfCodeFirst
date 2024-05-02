using EfCodeFirst.DataAccess.Models;

namespace EfCodeFirst.DataAccess.Seeds;

internal static class LanguageSeed
{
    public readonly static Language English = new()
    {
        Id = 1,
        Code = "en",
        Name = "English"
    };

    public readonly static Language Spanish = new()
    {
        Id = 2,
        Code = "es",
        Name = "Spanish"
    };

    public readonly static Language German = new()
    {
        Id = 3,
        Code = "de",
        Name = "German"
    };

    public readonly static Language Italian = new()
    {
        Id = 4,
        Code = "it",
        Name = "Italian"
    };

    public readonly static Language Japanese = new()
    {
        Id = 5,
        Code = "ja",
        Name = "Japanese"
    };

    public readonly static Language Hindi = new()
    {
        Id = 6,
        Code = "hi",
        Name = "Hindi"
    };

    public static IReadOnlyList<Language> Languages => new Language[]
    {
        English,
        Spanish,
        German,
        Italian,
        Japanese,
        Hindi
    };
}
