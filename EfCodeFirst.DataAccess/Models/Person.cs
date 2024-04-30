using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

public class Person
{
    [Key]
    [Column(name: "person_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int PersonId { get; set; }

    [Column(name: "gender_id")]
    [Required]
    public int GenderId { get; set; }

    [Column(name: "person_name")]
    [Required]
    [MaxLength(500)]
    public string PersonName { get; set; } = string.Empty;

    public virtual Gender Gender { get; set; } = null!;
}
