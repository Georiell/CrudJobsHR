using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudJobsHR.Models
{
    [Table("regions")]
    public class Region
    {
        [Key]
        [Column("region_id")]
        public int RegionId { get; set; }

        [Column("region_name")]
        public string? RegionName { get; set; }

        public ICollection<Country> Countries { get; set; } = new List<Country>();
    }
}
