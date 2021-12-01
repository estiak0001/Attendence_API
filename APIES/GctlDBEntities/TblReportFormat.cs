using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("tbl_ReportFormat")]
    public partial class TblReportFormat
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal Id { get; set; }
        [Column("formatID")]
        [StringLength(50)]
        public string FormatId { get; set; }
        [Column("formatName")]
        [StringLength(50)]
        public string FormatName { get; set; }
        [Column("entryDate", TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [Column("modifyDate", TypeName = "datetime")]
        public DateTime? ModifyDate { get; set; }
    }
}
