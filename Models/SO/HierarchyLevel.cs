using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SO
{
    [Table("so_hierarchy_levels")]
    public class HierarchyLevel : AuditEntity
    {
        public int LevelOrder { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(10)]
        public string LegislationCode { get; set; }
    }

}
