using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_MenuTab2")]
    public partial class CoreMenuTab2
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("title")]
        [StringLength(250)]
        public string Title { get; set; }
        [Column("ParentID")]
        [StringLength(100)]
        public string ParentId { get; set; }
        [StringLength(50)]
        public string MenuId { get; set; }
        [StringLength(50)]
        public string OrderBy { get; set; }
        [StringLength(100)]
        public string ControllerName { get; set; }
        [StringLength(100)]
        public string ViewName { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
    }
}
