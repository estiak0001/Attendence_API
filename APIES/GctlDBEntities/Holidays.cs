using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HOLIDAYS")]
    public partial class Holidays
    {
        [Key]
        [Column("HOLIDAYID")]
        public int Holidayid { get; set; }
        [Column("HOLIDAYNAME")]
        [StringLength(20)]
        public string Holidayname { get; set; }
        [Column("HOLIDAYYEAR")]
        public short? Holidayyear { get; set; }
        [Column("HOLIDAYMONTH")]
        public short? Holidaymonth { get; set; }
        [Column("HOLIDAYDAY")]
        public short? Holidayday { get; set; }
        [Column("STARTTIME", TypeName = "datetime")]
        public DateTime? Starttime { get; set; }
        [Column("DURATION")]
        public short? Duration { get; set; }
        [Column("HOLIDAYTYPE")]
        public short? Holidaytype { get; set; }
        [Column("XINBIE")]
        [StringLength(4)]
        public string Xinbie { get; set; }
        [Column("MINZU")]
        [StringLength(50)]
        public string Minzu { get; set; }
        [Column("DeptID")]
        public short? DeptId { get; set; }
    }
}
