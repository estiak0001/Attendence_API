using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_ATD_MachineData")]
    public partial class HrmAtdMachineData
    {
        [Key]
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("FingerPrintID")]
        [StringLength(50)]
        public string FingerPrintId { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Time { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        [Column("IsIN")]
        public bool IsIn { get; set; }
    }
}
