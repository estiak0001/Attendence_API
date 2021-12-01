using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_AccessCode2")]
    public partial class CoreAccessCode2
    {
        [Key]
        [Column("AccessID")]
        public int AccessId { get; set; }
        [Required]
        [Column("AccessCodeID")]
        [StringLength(50)]
        public string AccessCodeId { get; set; }
        public string AccessCodeName { get; set; }
        [StringLength(10)]
        public string TitleCheck { get; set; }
        [Column("title")]
        [StringLength(250)]
        public string Title { get; set; }
        public string PageUrl { get; set; }
        [Column("chkAdd")]
        [StringLength(10)]
        public string ChkAdd { get; set; }
        [Column("chkEdit")]
        [StringLength(10)]
        public string ChkEdit { get; set; }
        [Column("chkDelete")]
        [StringLength(10)]
        public string ChkDelete { get; set; }
        [Column("chkPrint")]
        [StringLength(10)]
        public string ChkPrint { get; set; }
        [Column("ParentID")]
        [StringLength(100)]
        public string ParentId { get; set; }
        [StringLength(50)]
        public string MenuId { get; set; }
        [StringLength(50)]
        public string OrderBy { get; set; }
        [StringLength(100)]
        public string MenuText { get; set; }
        [StringLength(100)]
        public string ControllerName { get; set; }
        [StringLength(100)]
        public string ViewName { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
    }
}
