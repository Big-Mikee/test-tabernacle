using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SO
{
    [Table("so_offices")]
    public class Office : AuditEntity
    {

        [Required]
        [StringLength(50)]
        public string HierarchyLevelCode { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int RankOrder { get; set; }
        
    }
}
