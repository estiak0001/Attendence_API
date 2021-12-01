using APIES.GctlDBEntities;
using APIES.Models.ManualAttendence;
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
    public class ManualAttendenceController : ControllerBase
    {
        private readonly IManualAttendenceService _manualAttendenceService;
        private readonly IMapper _mapper;

        public ManualAttendenceController(IManualAttendenceService manualAttendenceService, IMapper mapper)
        {
            _manualAttendenceService = manualAttendenceService ??
                throw new ArgumentNullException(nameof(manualAttendenceService));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        //[AllowAnonymous]
        //[HttpGet("getSalseDaliveryLocationEMaxID")]
        //public ActionResult<CustomIDDaliveryLocation> GetSalseDaliveryLocationEMaxID()
        //{
        //    var salesDaliveryLocation = _salserDaliveryLocation.GetID();
        //    return Ok(_mapper.Map<CustomIDDaliveryLocation>(salesDaliveryLocation));
        //}

        //[AllowAnonymous]
        //[HttpGet("getSalseContactPerson")]
        //public ActionResult<IEnumerable<SalesContactPersonDto>> GetSalseContactPerson()
        //{
        //    var salesContactPerson = _salserDaliveryLocation.GetSalseContactPerson();
        //    return Ok(_mapper.Map<IEnumerable<SalesContactPersonDto>>(salesContactPerson));
        //}
        [AllowAnonymous]
        [HttpPost("addManualAttendence")]
        public ActionResult<HrmAtdManualDto> AddManualAttendence(
            [FromBody] HrmAtdManualDto hrmAtdManualDto)
        {
            //if (_manualAttendenceService.ManualAttendenceExists(hrmAtdManualDto.ManualCode) == true)
            //{
            //    return BadRequest(new { message = "Data Already Exist!" });
            //}

            var manualAttendenceEntity = _mapper.Map<HrmAtdManual>(hrmAtdManualDto);
            _manualAttendenceService.AddManualAttendence(manualAttendenceEntity, hrmAtdManualDto.type);
            _manualAttendenceService.Save();


            return Ok(_mapper.Map<HrmAtdManualDto>(manualAttendenceEntity));
        }

        //[AllowAnonymous]
        //[HttpPost("updateSalseDaliveryLocation")]
        //public ActionResult<CreateSalesDeliveryLocationDto> UpdateSalseDaliveryLocation(string salesDaliveryCode,
        //    [FromBody] CreateSalesDeliveryLocationDto salseDaliveryLocation)
        //{
        //    if (_salserDaliveryLocation.SalseDaliveryLocationExists(salseDaliveryLocation.LocationAddress) == true)
        //    {
        //        return BadRequest(new { message = "Data Already Exist!" });
        //    }

        //    var salseDaliveryLocationEntity = _mapper.Map<SalesDeliveryLocation>(salseDaliveryLocation);
        //    _salserDaliveryLocation.AddSalseDeliveryLocation(salseDaliveryLocationEntity);
        //    _salserDaliveryLocation.Save();


        //    return Ok(_mapper.Map<CreateSalesDeliveryLocationDto>(salseDaliveryLocationEntity));
        //    //var salesDaliveryLocationToReturn = _mapper.Map<CreateSalesDeliveryLocationDto>(salseDaliveryLocationEntity);
        //    //return CreatedAtRoute("GetCourseForAuthor",
        //    //    new { deliveryLocationCode = salesDaliveryLocationToReturn.DeliveryLocationCode },
        //    //    salesDaliveryLocationToReturn);
        //}

        //[AllowAnonymous]
        //[HttpPut("updateSalesDeliveryLocation/{id}")]
        //public IActionResult UpdateSalesDeliveryLocation(string id, [FromBody] UpdateSalesDeliveryLocationDto model)
        //{
        //    // map model to entity and set id
        //    var salesDaliveryLocations = _mapper.Map<SalesDeliveryLocation>(model);
        //    salesDaliveryLocations.DeliveryLocationCode = id;

        //    try
        //    {
        //        // update data 
        //        _salserDaliveryLocation.UpdateSalesDaliveryLocation(salesDaliveryLocations);
        //        return Ok();
        //    }
        //    catch (AppException ex)
        //    {
        //        // return error message if there was an exception
        //        return BadRequest(new { message = ex.Message });
        //    }
        //}

    }
}

