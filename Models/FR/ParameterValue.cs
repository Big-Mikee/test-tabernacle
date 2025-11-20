using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FR
{
    public class ParameterValue : AuditEntity
    {
        [StringLength(50)]
        public string ParameterCode { get; set; }

        public string Value { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; }

        [StringLength(50)]
        public string HierarchyInstanceCode { get; set; }

    }
}
