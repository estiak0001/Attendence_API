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
        [HttpGet("leaveLandingPage/{LeaveEntryID}/{EmployeeID}")]
        public ActionResult<LeaveApplicationEntryDto> LeaveLandingPage(string LeaveEntryID, string EmployeeID)
        {
            if(LeaveEntryID== null)
            {
                LeaveApplicationEntryDto data = new LeaveApplicationEntryDto();
                data.ATDLeaveType = _manualAttendenceService.GetAllLeaveType();
                data.LeaveBalanceStatus = _manualAttendenceService.GetEmployeeLeaveStatus(EmployeeID);
                return data;
            }
            else
            {
                LeaveApplicationEntryDto data = new LeaveApplicationEntryDto();
                data = _manualAttendenceService.GetLeaveInfo(LeaveEntryID);
                data.ATDLeaveType = _manualAttendenceService.GetAllLeaveType();
                data.LeaveBalanceStatus = _manualAttendenceService.GetEmployeeLeaveStatus(EmployeeID);
                return data;
            }
        }
    }
}
