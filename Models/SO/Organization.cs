using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SO
{
    [Table("so_organizations")]
    public class Organization : AuditEntity
    {
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(100)]
        public string State { get; set; }

        [MaxLength(100)]
        public string City { get; set; }

        [MaxLength(20)]
        public string Zipcode { get; set; }

        [MaxLength(50)]
        public string DefaultLanguage { get; set; }

        [MaxLength(7)]
        public string BrandColor { get; set; }

        [MaxLength(500)]
        public string LogoUrl { get; set; }

        [MaxLength(50)]
        public string OrganizationType { get; set; }

        public bool AllowVolunteer { get; set; }
    }

}
