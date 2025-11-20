using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB
{
    [Table("fb_form_response_values")]
    public class FormResponseValue : AuditEntity
    {

        [MaxLength(50)]
        public string FormResponseCode { get; set; }

        [MaxLength(50)]
        public string FormFieldCode { get; set; }

        public string ValueText { get; set; }

        public decimal ValueNumber { get; set; } = decimal.Zero;

        public bool ValueBool { get; set; }
    }
}
