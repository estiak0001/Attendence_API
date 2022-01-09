using APIES.Helper.ModelHelper;
using APIES.Models.Leave;
using APIES.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIES.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class LeaveController
    {
        private readonly IManualAttendenceService _manualAttendenceService;
        private readonly IMapper _mapper;

        public LeaveController(IManualAttendenceService manualAttendenceService, IMapper mapper)
        {
            _manualAttendenceService = manualAttendenceService ??
                throw new ArgumentNullException(nameof(manualAttendenceService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpPost("leaveApply")]
        public ActionResult<ResponseModel> LeaveApply([FromBody] LeaveApplicationEntryDto Model)
        {
            var leaveData = _manualAttendenceService.LeaveApply(Model);
            return leaveData;
        }

        [AllowAnonymous]
        [HttpGet("leaveLandingPage/{EmployeeID}/{LeaveEntryID}/{Status}")]
        public ActionResult<LeaveApplicationEntryDto> LeaveLandingPage(string LeaveEntryID, string EmployeeID, string Status)
        {
            if(LeaveEntryID== null || LeaveEntryID =="")
            {
                LeaveApplicationEntryDto data = new LeaveApplicationEntryDto();
                data.ATDLeaveType = _manualAttendenceService.GetAllLeaveType();
                data.LeaveBalanceStatus = _manualAttendenceService.GetEmployeeLeaveStatus(EmployeeID);
                data.HolidayList = _manualAttendenceService.GetAllHolidayInfo();
                data.CompannyWeekendList = _manualAttendenceService.CompannyWeekendList().Weekend;
                data.LeaveHistory = _manualAttendenceService.GetAllLeaveInfo(EmployeeID, Status);
                return data;
            }
            else
            {
                LeaveApplicationEntryDto data = new LeaveApplicationEntryDto();
                data = _manualAttendenceService.GetLeaveInfo(LeaveEntryID);
                data.ATDLeaveType = _manualAttendenceService.GetAllLeaveType();
                data.LeaveBalanceStatus = _manualAttendenceService.GetEmployeeLeaveStatus(EmployeeID);
                data.HolidayList = _manualAttendenceService.GetAllHolidayInfo();
                data.CompannyWeekendList = _manualAttendenceService.CompannyWeekendList().Weekend;
                data.LeaveHistory = _manualAttendenceService.GetAllLeaveInfo(EmployeeID, Status);
                return data;
            }
        }

        [AllowAnonymous]
        [HttpGet("LeaveHistory/{EmployeeID}/{status}")]
        public IEnumerable<LeaveApplicationEntryDto> LeaveHistory(string EmployeeID, string status)
        {
            var history = _manualAttendenceService.GetAllLeaveInfo(EmployeeID, status);

            return history;
        }
    }
}
