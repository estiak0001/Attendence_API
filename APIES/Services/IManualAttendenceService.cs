using APIES.GctlDBEntities;
using APIES.Helper.ModelHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Services
{
    public interface IManualAttendenceService
    {
        CustomID GetID();
        IEnumerable<HrmAtdManual> GetManualAttendence();
        void UpdateManualAttendence(HrmAtdManual hrmAtdManual);
        void DeleteManualAttendence(HrmAtdManual hrmAtdManual);
        void AddManualAttendence(HrmAtdManual hrmAtdManual, string type);
        bool ManualAttendenceExists(string salseDaliveryLocation);
        bool Save();
    }
}
