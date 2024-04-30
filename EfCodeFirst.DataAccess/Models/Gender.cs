using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

public class Gender
{
    [Key]
    [Column(name: "gender_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [Column(name: "gender")]
    [Required]
    [MaxLength(20)]
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Person> Persons { get; } = Array.Empty<Person>();
}
