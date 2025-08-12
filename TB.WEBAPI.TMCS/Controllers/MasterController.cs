using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Masters;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/master/")]
    [ApiController]
    public class MasterController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("address/district")]
        public async Task<IActionResult> GetAddressDistrict([FromBody] AddressDistrictRequest request)
        {
            var response = await _apiClientService.PostAsync<AddressDistrictRequest, IEnumerable<AddressDistrictListResponse>>("/apiMaster/district", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("address/province")]
        public async Task<IActionResult> GetAddressProvince()
        {
            var response = await _apiClientService.PostAsync<IEnumerable<AddressProvinceListResponse>>("/apiMaster/province");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("address/subdistrict")]
        public async Task<IActionResult> GetAddressSubDistrict([FromBody] AddressSubDistrictRequest request)
        {
            var response = await _apiClientService.PostAsync<AddressSubDistrictRequest, IEnumerable<AddressSubDistrictListResponse>>("/apiMaster/subdistrict", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("car/seat")]
        public async Task<IActionResult> GetCarBodySeat()
        {
            var response = await _apiClientService.PostAsync<IEnumerable<CarBodySeatListResponse>>("/apiMaster/carBodySeat");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("car/brand")]
        public async Task<IActionResult> GetCarBrand([FromBody] CarBrandRequest request)
        {
            var response = await _apiClientService.PostAsync<CarBrandRequest, IEnumerable<CarBrandListResponse>>("/apiMaster/carBrand", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("car/color")]
        public async Task<IActionResult> GetCarColor([FromBody] CarColourRequest request)
        {
            var response = await _apiClientService.PostAsync<CarColourRequest, IEnumerable<CarColorListResponse>>("/apiMaster/carColour", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("car/compulsory/code")]
        public async Task<IActionResult> GetCarCompulsoryCode()
        {
            var response = await _apiClientService.PostAsync<IEnumerable<CarComCodeListResponse>>("/apiMaster/cop_Carcode");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("car/compulsory/subcode")]
        public async Task<IActionResult> GetCarCompulsorySubCode([FromBody] CarComSubCodeRequest request)
        {
            var response = await _apiClientService.PostAsync<CarComSubCodeRequest, IEnumerable<CarComSubCodeListResponse>>("/apiMaster/cop_CarSubcode", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("car/model")]
        public async Task<IActionResult> GetCarModel([FromBody] CarModelRequest request)
        {
            var response = await _apiClientService.PostAsync<CarModelRequest, IEnumerable<CarModelListResponse>>("/apiMaster/carModel", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
        [HttpPost("car/use")]
        public async Task<IActionResult> GetCarUse()
        {
            var response = await _apiClientService.PostAsync<IEnumerable<CarUsedListResponse>>("/apiMaster/carUsed");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
        [HttpPost("car/voluntary/code")]
        public async Task<IActionResult> GetCarVoluntaryCode()
        {
            var response = await _apiClientService.PostAsync<IEnumerable<CarVolCodeListResponse>>("/apiMaster/vol_Carcode");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
        [HttpPost("categorical/occupation")]
        public async Task<IActionResult> GetOccupation([FromBody] OccupationRequest request)
        {
            var response = await _apiClientService.PostAsync<OccupationRequest, IEnumerable<OccupationListResponse>>("/apiMaster/occupation", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("categorical/prename")]
        public async Task<IActionResult> GetPrename([FromBody] PreNameRequest request)
        {
            var response = await _apiClientService.PostAsync<PreNameRequest, IEnumerable<PreNameListResponse>>("/apiMaster/prename", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("categorical/relationship")]
        public async Task<IActionResult> GetRelationship()
        {
            var response = await _apiClientService.PostAsync<IEnumerable<RelationshipResponse>>("/apiMaster/insRelation");
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}