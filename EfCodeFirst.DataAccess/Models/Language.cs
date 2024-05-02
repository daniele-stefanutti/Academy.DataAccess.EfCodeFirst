using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

public class Language
{
    [Key]
    [Column(name: "language_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [Column(name: "language_code")]
    [Required]
    [MaxLength(10)]
    public string Code { get; set; } = string.Empty;

    [Column(name: "language_name")]
    [Required]
    [MaxLength(500)]
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<MovieLanguages> MovieLanguages { get; } = Array.Empty<MovieLanguages>();
}
