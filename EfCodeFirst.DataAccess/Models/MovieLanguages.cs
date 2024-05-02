using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

[Table("Movie_Languages")]
public class MovieLanguages
{
    [Key]
    [Column(name: "movie_id")]
    public int MovieId { get; set; }

    [Key]
    [Column(name: "language_id")]
    public int LanguageId { get; set; }

    public Movie Movie { get; set; } = null!;
    public Language Language { get; set; } = null!;
}
