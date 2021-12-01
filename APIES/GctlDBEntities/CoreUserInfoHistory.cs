using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_UserInfo_History")]
    public partial class CoreUserInfoHistory
    {
        [Column("BID")]
        public int Bid { get; set; }
        [Column("ID")]
        public int? Id { get; set; }
        [Column("username")]
        [StringLength(250)]
        public string Username { get; set; }
        [Column("password")]
        [StringLength(250)]
        public string Password { get; set; }
        [StringLength(250)]
        public string Type { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(250)]
        public string AccessCode { get; set; }
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [Column("EmployeeID")]
        [StringLength(100)]
        public string EmployeeId { get; set; }
        [Column("DOB", TypeName = "smalldatetime")]
        public DateTime? Dob { get; set; }
        [StringLength(50)]
        public string OffPhone { get; set; }
        [StringLength(50)]
        public string PerPhone { get; set; }
        [StringLength(150)]
        public string OffEmail { get; set; }
        [StringLength(150)]
        public string PerEmail { get; set; }
        [StringLength(50)]
        public string Role { get; set; }
        [StringLength(50)]
        public string SingleSession { get; set; }
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
    }
}
