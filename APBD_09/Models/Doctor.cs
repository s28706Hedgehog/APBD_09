using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_09.Models;

[Table("Doctor")]
public class Doctor
{
    [Key] public int IdDoctor { get; set; }
    [MaxLength(100)] public required string FirstName { get; set; } = null!;
    [MaxLength(100)] public required string LastName { get; set; } = null!;
    [MaxLength(100)] public required string Email { get; set; } = null!;

    public virtual ICollection<Prescription> Prescriptions { get; set; } = null!;
}