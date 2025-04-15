using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;

namespace CrudJobsHR.Models
{
    [Table("locations")]
    public class Location
    {
        [Key]
        [Column("location_id")]
        public int LocationId { get; set; }

        [Column("street_address")]
        public string? StreetAddress { get; set; }

        [Column("postal_code")]
        public string? PostalCode { get; set; }

        [Required]
        [Column("city")]
        public string City { get; set; } = string.Empty;

        [Column("state_province")]
        public string? StateProvince { get; set; }

        [Column("country_id")]
        public string CountryId { get; set; } = string.Empty;

        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

        public ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}
