using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FR
{
    [Table("fr_remittance_rules")]
    public class RemittanceRule : AuditEntity
    {
        [StringLength(50)]
        public string SourceLevelCode { get; set; }

        [StringLength(50)]
        public string RemitToLevelCode { get; set; }

        [StringLength(50)]
        public string RevenueItemCode { get; set; }
        public decimal Percentage { get; set; }

        [StringLength(50)]
        public string Frequency { get; set; }

        [StringLength(50)]
        public string Method { get; set; }

    }
}
