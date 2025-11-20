using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SO
{
    [Table("so_hierarchy_instances")]
    public class HierachyInstances : AuditEntity
    {
        [Required]
        [StringLength(50)]
        public string HierarchyLevelCode { get; set; }

        [StringLength(50)]
        public string ParentCode { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string State { get; set; }

        public bool IsActive { get; set; }

    }
}
