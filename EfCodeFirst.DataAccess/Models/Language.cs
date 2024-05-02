using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

public class Language
{
    [Key]
    [Column(name: "language_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int LanguageId { get; set; }

    [Column(name: "language_code")]
    [Required]
    [MaxLength(10)]
    public string LanguageCode { get; set; } = string.Empty;

    [Column(name: "language_name")]
    [Required]
    [MaxLength(500)]
    public string LanguageName { get; set; } = string.Empty;

    public virtual ICollection<MovieLanguages> MovieLanguages { get; } = Array.Empty<MovieLanguages>();
}
