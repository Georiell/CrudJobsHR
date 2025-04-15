using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudJobsHR.Models
{
    [Table("jobs")]
    public class Job
    {
        [Key]
        [Column("job_id")]
        public int JobId { get; set; }

        [Required(ErrorMessage = "El título del trabajo es obligatorio.")]
        [Display(Name = "Título del trabajo")]
        [Column("job_title")]
        public string JobTitle { get; set; } = string.Empty;

        [Display(Name = "Salario mínimo")]
        [Column("min_salary", TypeName = "decimal(8,2)")]
        public decimal? MinSalary { get; set; }

        [Display(Name = "Salario máximo")]
        [Column("max_salary", TypeName = "decimal(8,2)")]
        
        public decimal? MaxSalary { get; set; }

        // Relación con empleados
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
