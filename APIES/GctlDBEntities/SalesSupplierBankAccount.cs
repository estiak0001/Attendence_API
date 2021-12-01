using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Sales_SupplierBankAccount")]
    public partial class SalesSupplierBankAccount
    {
        [Column(TypeName = "numeric(18, 0)")]
        public decimal AutoId { get; set; }
        [Required]
        [Column("SBAID")]
        [StringLength(50)]
        public string Sbaid { get; set; }
        [Required]
        [Column("SupplierID")]
        [StringLength(50)]
        public string SupplierId { get; set; }
        [Required]
        [Column("BankID")]
        [StringLength(50)]
        public string BankId { get; set; }
        [Required]
        [Column("BankBranchID")]
        [StringLength(100)]
        public string BankBranchId { get; set; }
        [StringLength(250)]
        public string AccountName { get; set; }
        [Column("LUser")]
        [StringLength(50)]
        public string Luser { get; set; }
    }
}
