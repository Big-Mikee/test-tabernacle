using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_roles")]
    public class Role : AuditEntity
    {
        [Required]
       
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }


    }
}
