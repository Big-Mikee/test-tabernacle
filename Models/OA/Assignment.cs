using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.OA
{
    [Table("oa_assignments")]
    public class Assignment : AuditEntity
    {
        [Required]
        [MaxLength(50)]
        public string UserCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string OfficeCode { get; set; }

        [MaxLength(50)]
        public string HierarchyInstanceCode { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }

}
