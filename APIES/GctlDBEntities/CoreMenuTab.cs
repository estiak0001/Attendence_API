using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_MenuTab")]
    public partial class CoreMenuTab
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("parentID")]
        public int? ParentId { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        public int? Status { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("OPStatus")]
        [StringLength(10)]
        public string Opstatus { get; set; }
        public int? MenuOrder { get; set; }
        [Column("ModuleID")]
        public int? ModuleId { get; set; }
        public int? GridOrder { get; set; }
    }
}
