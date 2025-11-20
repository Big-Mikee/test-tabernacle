using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_tabernacle.Models.OA
{
    [Table("oa_chapter_movement_logs")]
    public class ChapterMovementLog : AuditEntity
    {

        [StringLength(50)]
        public string ChapterCode { get; set; }

        [StringLength(50)]
        public string OldParentCode { get; set; }

        [StringLength(50)]
        public string NewParentCode { get; set; }

        [StringLength(500)]
        public string Reason { get; set; }

        public DateTime MovedOn { get; set; }

        [StringLength(50)]
        public string MovedBy { get; set; }
    }
}
