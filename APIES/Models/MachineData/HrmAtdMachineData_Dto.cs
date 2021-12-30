using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.MachineData
{
    public class HrmAtdMachineData_Dto
    {
        public string FingerPrintId { get; set; }
        public string MachineId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
