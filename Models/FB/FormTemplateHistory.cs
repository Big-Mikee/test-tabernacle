using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB
{
    [Table("fb_form_template_history")]
    public class FormTemplateHistory : AuditEntity
    {
        [Column("TemplateCode")]
        [StringLength(50)]
        public string TemplateCode { get; set; }

        [Column("Version")]
        public int Version { get; set; }

        [Column("Name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("Module")]
        [StringLength(50)]
        public string Module { get; set; }

        [Column("JsonDefinition")]
        public string JsonDefinition { get; set; }

        [Column("ChangedBy")]
        [StringLength(50)]
        public string ChangedBy { get; set; }

        [Column("ChangedOn")]
        public DateTime ChangedOn { get; set; }
    }
}
