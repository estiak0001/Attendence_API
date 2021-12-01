using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_AccessCode")]
    public partial class CoreAccessCode
    {
        [Column("AccessID")]
        public int AccessId { get; set; }
        [StringLength(50)]
        public string AccessCode { get; set; }
        [Column("id")]
        public int? Id { get; set; }
        [Column("ParentID")]
        public int? ParentId { get; set; }
        [Column("title")]
        [StringLength(250)]
        public string Title { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [Column("OPStatus")]
        [StringLength(10)]
        public string Opstatus { get; set; }
        public int? MenuOrder { get; set; }
        [Column("chkAdd")]
        public bool? ChkAdd { get; set; }
        [Column("chkUpdate")]
        public bool? ChkUpdate { get; set; }
        [Column("chkDelete")]
        public bool? ChkDelete { get; set; }
        [Column("chkClear")]
        public bool? ChkClear { get; set; }
        [Column("chkPrint")]
        public bool? ChkPrint { get; set; }
        public string AccessDesc { get; set; }
    }
}
