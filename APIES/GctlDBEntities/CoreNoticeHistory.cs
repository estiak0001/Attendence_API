using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_Notice_History")]
    public partial class CoreNoticeHistory
    {
        [Key]
        [Column("NoticeBID")]
        public int NoticeBid { get; set; }
        [Column("NoticeID")]
        public int? NoticeId { get; set; }
        [StringLength(250)]
        public string NoticeTitle { get; set; }
        public string NoticeDesc { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EntryDate { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(150)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(250)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
