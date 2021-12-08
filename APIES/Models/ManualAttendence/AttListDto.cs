using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.ManualAttendence
{
    public class AttListDto
    {
        
        public int SLNO { get; set; }
        public string AttendenceType { get; set; }
        public string AttDateANDTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

    }
}
