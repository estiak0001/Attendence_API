using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("HRM_EmployeeMonthlyMovementInfoDetailsExistingCustomer")]
    public partial class HrmEmployeeMonthlyMovementInfoDetailsExistingCustomer
    {
        [Column("autoId", TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("MMPDetailsID")]
        [StringLength(50)]
        public string MmpdetailsId { get; set; }
        [Required]
        [Column("MMPID")]
        [StringLength(50)]
        public string Mmpid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PlaningDate { get; set; }
        [Column("CustomerID")]
        [StringLength(50)]
        public string CustomerId { get; set; }
        public string VisitParticuler { get; set; }
        [Column("AreaID")]
        [StringLength(50)]
        public string AreaId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        [Column("UserInfoEmployeeID")]
        [StringLength(50)]
        public string UserInfoEmployeeId { get; set; }
    }
}
