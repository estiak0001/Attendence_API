using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_UserInfo2")]
    public partial class CoreUserInfo2
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("username")]
        [StringLength(250)]
        public string Username { get; set; }
        [Required]
        [StringLength(250)]
        public string AccessCode { get; set; }
        [Column("EmployeeID")]
        [StringLength(100)]
        public string EmployeeId { get; set; }
        [StringLength(50)]
        public string Role { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? EntryDate { get; set; }
        [Column("LUser")]
        [StringLength(250)]
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
        [Required]
        [StringLength(500)]
        public string UserPassword { get; set; }
    }
}
