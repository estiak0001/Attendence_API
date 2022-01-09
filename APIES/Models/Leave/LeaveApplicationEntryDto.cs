﻿using APIES.Models.Holiday;
using APIES.Models.Weekend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Models.Leave
{
    public class LeaveApplicationEntryDto
    {
        public string LeaveAppEntryId { get; set; }
        public string EmployeeID { get; set; }
        public string LeaveType { get; set; }
        public string LeaveTypeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal NoOfDay { get; set; }
        public string HalfDay { get; set; }
        public string FirstOrSecondHalf { get; set; }
        public string Reason { get; set; }
        public string BossEmpAutoId { get; set; }
        public string HOD { get; set; }
        public string IsApproved { get; set; }
        public string LUser { get; set; }
        public string LDate { get; set; }
        public string LIP { get; set; }
        public string LMAC { get; set; }
        public string ModifyDate { get; set; }
        public string ConfirmationRemarks { get; set; }
        public string CompanyCode { get; set; }
        public string HODApprovalStatus { get; set; }
        public string HODApprovalRemarks { get; set; }
        public string HRApprovalStatus { get; set; }
        public string HRApprovalRemarks { get; set; }
        public string ApplyLeaveFormat { get; set; }
        public string ShortLeaveFrom { get; set; }
        public string ShortLeaveTo { get; set; }
        public string ShortLeaveTime { get; set; }
        public string LeaveApplyProcess { get; set; }

        public string ApplyDate { get; set; }
        public string EmployeeName { get; set; }

        public string DepartmentCode { get; set; }
        public string DesignationCode { get; set; }
        public List<string> LeaveDaysList { get; set; }

        //public HttpFileCollectionBase FileString { get; set; }
        public List<string> CompannyWeekendList { get; set; }
        public List<ATDLeaveType> ATDLeaveType { get; set; }
        public List<LeaveBalanceStatus> LeaveBalanceStatus { get; set; }
        //public List<CompannyWeekend> CompannyWeekendList { get; set; }
        public List<ATD_Holiday> HolidayList { get; set; }

        public List<LeaveApplicationEntryDto> LeaveHistory { get; set; }
    }
}
