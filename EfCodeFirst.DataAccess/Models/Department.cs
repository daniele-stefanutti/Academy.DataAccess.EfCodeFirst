using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCodeFirst.DataAccess.Models;

[Table("Department")]
public class Department
{
    [Key]
    [Column(name: "department_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    [Column(name: "department_name")]
    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<MovieCrew> MovieCrews { get; } = Array.Empty<MovieCrew>();
}
