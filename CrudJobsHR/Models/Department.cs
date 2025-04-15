using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudJobsHR.Models
{
    [Table("departments")]
    public class Department
    {
        [Key]
        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Required]
        [Column("department_name")]
        public string DepartmentName { get; set; } = string.Empty;

        [Column("location_id")]
        public int? LocationId { get; set; }

        [ForeignKey("LocationId")]
        public Location? Location { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
