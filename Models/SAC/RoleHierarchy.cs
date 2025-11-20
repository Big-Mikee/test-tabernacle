using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_role_hierarchy")]
    public class RoleHierarchy : AuditEntity
    {

        [StringLength(50)]
        public string ParentRoleCode { get; set; }

        [StringLength(50)]
        public string ChildRoleCode { get; set; }
    }
}
