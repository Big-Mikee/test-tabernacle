using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB
{
    [Table("fb_form_field_options")]
    public class FormFieldOption : AuditEntity
    {
        [MaxLength(50)]
        public string FormFieldCode { get; set; }

        [MaxLength(100)]
        public string Label { get; set; }

        [MaxLength(100)]
        public string Value { get; set; }

        public int SortOrder { get; set; }
    }
}
