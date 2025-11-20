using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_role_activity_codes")]
    public class RoleActivityCode : AuditEntity
    {
        [MaxLength(50)]
        public string RoleCode { get; set; }

        [MaxLength(50)]
        public string ActivityCode { get; set; }
    }
}
