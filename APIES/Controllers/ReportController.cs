using APIES.Models.Leave;
using APIES.Models.Report;
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
    public class ReportController : ControllerBase
    {
        private readonly IManualAttendenceService _manualAttendenceService;
        private readonly IMapper _mapper;

        public ReportController(IManualAttendenceService manualAttendenceService, IMapper mapper)
        {
            _manualAttendenceService = manualAttendenceService ??
                throw new ArgumentNullException(nameof(manualAttendenceService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [AllowAnonymous]
        [HttpPost("GetEmployeeJobCard")]
        public ActionResult<EmployeeJobCard> GetEmployeeJobCard([FromBody] paramJobCard data)
        {
            //12/12/2021
            var EmployeeJobCard = _manualAttendenceService.EmployeeJobCard(data.FromDate, data.ToDate, data.EmployeeID);
            return Ok(EmployeeJobCard);
        }


    }
}
