using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB
{
    [Table("fb_form_fields")]
    public class FormField : AuditEntity
    {
        [MaxLength(50)]
        public string FormTemplateCode { get; set; }

        [MaxLength(50)]
        public string ParentFieldCode { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string DataType { get; set; }

        public bool IsRequired { get; set; }

        [MaxLength(100)]
        public string GroupName { get; set; }

        public int SortOrder { get; set; }
    }
}
