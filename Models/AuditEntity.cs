using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models
{
    public class AuditEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [MaxLength(50)]
        public string Code { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;

        [MaxLength(50)]
        public string? ModifiedBy { get; set; }
    }
}
