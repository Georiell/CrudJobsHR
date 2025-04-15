using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudJobsHR.Models
{
    [Table("dependents")]
    public class Dependent
    {
        [Key]
        [Column("dependent_id")]
        public int DependentId { get; set; }

        [Required]
        [Column("first_name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Column("relationship")]
        public string Relationship { get; set; } = string.Empty;

        [Required]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee? Employee { get; set; }
    }
}
