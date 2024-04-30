using EfCodeFirst.DataAccess.Models;

namespace EfCodeFirst.DataAccess.Seeds;

internal static class GenderSeed
{
    public readonly static Gender Female = new()
    {
        Id = 1,
        Name = "Female"
    };

    public readonly static Gender Male = new()
    {
        Id = 2,
        Name = "Male"
    };

    public readonly static Gender Unspecified = new()
    {
        Id = 3,
        Name = "Unspecified"
    };

    public static IReadOnlyList<Gender> Genders => new Gender[]
    {
        Female,
        Male,
        Unspecified
    };
}
