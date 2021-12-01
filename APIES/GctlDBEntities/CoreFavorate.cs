using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Core_Favorate")]
    public partial class CoreFavorate
    {
        [Key]
        [Column("FavID")]
        public int FavId { get; set; }
        [Column("PageID")]
        public int? PageId { get; set; }
        [Column("username")]
        [StringLength(50)]
        public string Username { get; set; }
        public int? Position { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [Column("LDate", TypeName = "smalldatetime")]
        public DateTime? Ldate { get; set; }
        [Column("LUser")]
        [StringLength(100)]
        public string Luser { get; set; }
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
