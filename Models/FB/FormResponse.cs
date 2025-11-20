using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB
{
    [Table("fb_form_responses")]
    public class FormResponse : AuditEntity
    {
        [Required]
        [StringLength(50)]
        public string FormTemplateCode { get; set; }

        [StringLength(50)]
        public string EntityType { get; set; }

        [StringLength(50)]
        public string EntityCode { get; set; }

        [Required]
        [StringLength(50)]
        public string SubmittedBy { get; set; }

        public DateTime SubmittedOn { get; set; }
    }
}
