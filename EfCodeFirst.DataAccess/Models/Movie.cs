using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

public class Movie
{
    [Key]
    [Column(name: "movie_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int MovieId { get; set; }

    [Required]
    [Column(name: "title")]
    public string Title { get; set; } = string.Empty;

    [Column(name: "budget")]
    public long? Budget { get; set; }

    [Column(name: "release_date")]
    public DateTime? ReleaseDate { get; set; }

    [Column(name: "revenue")]
    public long? Revenue { get; set; }

    [Column(name: "runtime")]
    public int? Runtime { get; set; }

    [Column(name: "votes_avg", TypeName = "decimal(5,3)")]
    public decimal? VotesAvg { get; set; }

    [Column(name: "votes_count")]
    public int? VotesCount { get; set; }

    public virtual ICollection<MovieCast> MovieCasts { get; set; } = Array.Empty<MovieCast>();
}
