using EfCodeFirst.DataAccess.Models;

namespace EfCodeFirst.DataAccess.Seeds;

internal static class DepartmentSeed
{
    public readonly static Department Camera = new()
    {
        Id = 1,
        Name = "Camera"
    };

    public readonly static Department Directing = new()
    {
        Id = 2,
        Name = "Directing"
    };

    public readonly static Department Production = new()
    {
        Id = 3,
        Name = "Production"
    };

    public readonly static Department Writing = new()
    {
        Id = 4,
        Name = "Writing"
    };

    public readonly static Department Editing = new()
    {
        Id = 5,
        Name = "Editing"
    };

    public readonly static Department Sound = new()
    {
        Id = 6,
        Name = "Sound"
    };

    public static IReadOnlyList<Department> Departments => new Department[]
    {
        Camera,
        Directing,
        Production,
        Writing,
        Editing,
        Sound
    };
}
