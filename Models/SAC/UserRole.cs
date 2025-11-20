using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_user_roles")]
    public class UserRole
    {

        [Required]
        [StringLength(50)]
        public string UserCode { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleCode { get; set; }
    }
}
