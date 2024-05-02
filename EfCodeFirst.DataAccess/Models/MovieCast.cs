using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

[Table("Movie_Cast")]
public class MovieCast
{
    [Key]
    [Column(name: "movie_id")]
    public int MovieId { get; set; }

    [Key]
    [Column(name: "person_id")]
    public int PersonId { get; set; }

    [Column(name: "character_name")]
    [MaxLength(400)]
    public string? CharacterName { get; set; }

    [Column(name: "cast_order")]
    public int? CastOrder { get; set; }

    public Movie Movie { get; set; } = null!;
    public Person Person { get; set; } = null!;
}
