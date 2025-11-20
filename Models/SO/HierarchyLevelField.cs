using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SO
{
    [Table("so_hierarchy_level_fields")]
    public class HierarchyLevelField : AuditEntity
    {

        [MaxLength(50)]
        public string HierarchyLevelCode { get; set; }

        [MaxLength(100)]
        public string FieldName { get; set; }

        public bool IsRequired { get; set; }

        public int SortOrder { get; set; }
    }
}
