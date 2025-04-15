using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CrudJobsHR.Models;

namespace CrudJobsHR.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Required]
        [Column("last_name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("phone_number")]
        public string? PhoneNumber { get; set; }

        [Required]
        [Column("hire_date")]
        public DateTime HireDate { get; set; }

        [Required]
        [Column("job_id")]
        public int JobId { get; set; }

        [Required]
        [Column("salary")]
        public decimal Salary { get; set; }

        [Column("manager_id")]
        public int? ManagerId { get; set; }

        [Column("department_id")]
        public int? DepartmentId { get; set; }

        // Relaciones
        [ForeignKey("JobId")]
        public Job? Job { get; set; }

        [ForeignKey("ManagerId")]
        public Employee? Manager { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

        public ICollection<Employee> Subordinates { get; set; } = new List<Employee>();
    }
}