using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIES.GctlDBEntities
{
    public partial class TableOfDates
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
