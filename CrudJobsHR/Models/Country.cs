using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace CrudJobsHR.Models
{
    [Table("countries")]
    public class Country
    {
        [Key]
        [Column("country_id")]
        public string CountryId { get; set; } = string.Empty;

        [Column("country_name")]
        public string? CountryName { get; set; }

        [Column("region_id")]
        public int RegionId { get; set; }

        [ForeignKey("RegionId")]
        public Region? Region { get; set; }

        public ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
