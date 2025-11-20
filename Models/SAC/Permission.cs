using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_permissions")]
    public class Permission : AuditEntity
    {

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}
