using APIES.GctlDBEntities;
using APIES.Helper.ModelHelper;
using APIES.Models.Holiday;
using APIES.Models.Leave;
using APIES.Models.ManualAttendence;
using APIES.Models.Report;
using APIES.Models.Weekend;
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
        void AddMachineData(HrmAtdMachineData hrmAtdMachineData);
        bool ManualAttendenceExists(string salseDaliveryLocation);
        AttendenceInfoDto GetLandingInfo(string EmployeeID);
        bool Save();

        //Report

        IEnumerable<EmployeeJobCard> EmployeeJobCard(string FromDate, string ToDate, string EmployeeID);
        ResponseModel LeaveApply(LeaveApplicationEntryDto Model);
        List<ATDLeaveType> GetAllLeaveType();
        LeaveApplicationEntryDto GetLeaveInfo(string LeaveAppEntryId);
        List<LeaveBalanceStatus> GetEmployeeLeaveStatus(string EmployeeID);

        List<ATD_Holiday> GetAllHolidayInfo();
        CompannyWeekend CompannyWeekendList();

        List<LeaveApplicationEntryDto> GetAllLeaveInfo(string empID, string status);
    }
}
