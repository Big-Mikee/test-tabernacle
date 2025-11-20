using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.AC
{
    [Table("ac_auditLogs")]
    public class AuditLog : AuditEntity
    {
        [StringLength(50)]
        public string UserCode { get; set; }

        [StringLength(100)]
        public string Action { get; set; }

        [StringLength(50)]
        public string EntityType { get; set; }

        [StringLength(50)]
        public string EntityCode { get; set; }

        public DateTime Timestamp { get; set; }

        [StringLength(45)]
        public string IPAddress { get; set; }

        [StringLength(500)]
        public string DeviceInfo { get; set; }
    }
}
