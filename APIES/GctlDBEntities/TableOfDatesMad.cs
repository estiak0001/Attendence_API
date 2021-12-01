using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    [Table("TableOfDates_MAD")]
    public partial class TableOfDatesMad
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
