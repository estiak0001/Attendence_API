using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_Attd_ProcessAttdLog")]
    public partial class HrmAttdProcessAttdLog1
    {
        [Column("TC", TypeName = "numeric(18, 0)")]
        public decimal Tc { get; set; }
        [Required]
        [Column("AttdLogHistoryID")]
        [StringLength(50)]
        public string AttdLogHistoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string AttdProcessType { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineId { get; set; }
        [Column("MachineIP")]
        [StringLength(20)]
        public string MachineIp { get; set; }
        public int? Port { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DownloadDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DownloadTime { get; set; }
        public int? DownloadRecordCount { get; set; }
        [StringLength(20)]
        public string AttdProcessStatus { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LIP")]
        [StringLength(50)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(50)]
        public string Lmac { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ModifyDate { get; set; }
        [StringLength(50)]
        public string CompanyCode { get; set; }
    }
}
