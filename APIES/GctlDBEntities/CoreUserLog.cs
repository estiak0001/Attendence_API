using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_UserLog")]
    public partial class CoreUserLog
    {
        [Key]
        [Column("ULogID")]
        public int UlogId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LoginDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? LogoutDate { get; set; }
        [Column("username")]
        [StringLength(250)]
        public string Username { get; set; }
        [Column("LIP")]
        [StringLength(250)]
        public string Lip { get; set; }
        [Column("LMAC")]
        [StringLength(150)]
        public string Lmac { get; set; }
        [StringLength(150)]
        public string WorkStation { get; set; }
        [Column("LMIP")]
        [StringLength(250)]
        public string Lmip { get; set; }
    }
}
