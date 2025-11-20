using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_role_permissions")]
    public class RolePermission : AuditEntity
    {

        [StringLength(50)]
        public string RoleCode { get; set; }

        [StringLength(50)]
        public string PermissionCode { get; set; }
    }
}
