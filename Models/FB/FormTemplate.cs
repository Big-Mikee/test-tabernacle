using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.FB 
{

    [Table("fb_form_templates")]
    public class FormTemplate : AuditEntity
    {
        [Required]
        [StringLength(50)]
        public string Module { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int Version { get; set; }

        public bool IsActive { get; set; }

    }
}
