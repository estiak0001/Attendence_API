using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("Temp_T_DatesBetweenDates2")]
    public partial class TempTDatesBetweenDates2
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
