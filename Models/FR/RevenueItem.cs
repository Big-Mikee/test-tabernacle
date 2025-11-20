using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FR
{
    [Table("fr_revenue_items")]
    public class RevenueItem : AuditEntity
    {
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(3)]
        public string Currency { get; set; } = "NGN";

        public bool IsTaxable { get; set; } = false;
        public decimal? TaxRate { get; set; }
    }
}
