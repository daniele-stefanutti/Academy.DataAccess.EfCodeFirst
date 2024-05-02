using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

public class MovieCrew
{
    [Key]
    [Column(name: "movie_id")]
    public int MovieId { get; set; }

    [Key]
    [Column(name: "person_id")]
    public int PersonId { get; set; }

    [Key]
    [Column(name: "department_id")]
    public int DepartmentId { get; set; }

    [Column(name: "job")]
    [MaxLength(200)]
    public string? Job { get; set; }

    public Movie Movie { get; set; } = null!;
    public Person Person { get; set; } = null!;
    public Department Department { get; set; } = null!;
}
