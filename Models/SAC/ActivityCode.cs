using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_activity_codes")]
    public class ActivityCode : AuditEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50)]
        public string Module { get; set; }

    }
}
