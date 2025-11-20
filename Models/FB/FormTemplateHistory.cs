using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB
{
    [Table("fb_form_template_history")]
    public class FormTemplateHistory : AuditEntity
    {
        [StringLength(50)]
        public string TemplateCode { get; set; }

        public int Version { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Module { get; set; }

        public string JsonDefinition { get; set; }

        [StringLength(50)]
        public string ChangedBy { get; set; }

        public DateTime ChangedOn { get; set; }
    }
}
