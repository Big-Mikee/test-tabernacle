using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.SAC
{
    [Table("sac_users")]

    public class User : AuditEntity
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone1 { get; set; }

        [StringLength(20)]
        public string Phone2 { get; set; }

        [Required]
        [StringLength(255)]
        public string PasswordHash { get; set; }

        public bool MFAEnabled { get; set; }

        [StringLength(500)]
        public string DeviceToken { get; set; }

    }
}
