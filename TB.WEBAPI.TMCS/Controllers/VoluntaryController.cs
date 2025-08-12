using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Voluntaries;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Voluntarys;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/voluntary/")]
    [ApiController]
    public class VoluntaryController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("fetch/commission")]
        public async Task<IActionResult> FetchVoluntaryCommission([FromBody] VoluntaryCommissionRequest request)
        {
            var response = await _apiClientService.PostAsync<VoluntaryCommissionRequest, IEnumerable<VoluntaryCommissionResponse>>("/apiPayment/GetComm_VMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/product")]
        public async Task<IActionResult> FetchVoluntaryProductCode([FromBody] VoluntaryProductCodeRequest request)
        {
            var response = await _apiClientService.PostAsync<VoluntaryProductCodeRequest, IEnumerable<VoluntaryProductCodeResponse>>("/apiMaster/insure_productcode", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/policy/detail")]
        public async Task<IActionResult> FetchVoluntaryPolicyDetail(VoluntaryPolicyDetailRequest request)
        {
            var response = await _apiClientService.PostAsync<VoluntaryPolicyDetailRequest, IEnumerable<VoluntaryPolicyDetailResponse>>("/apiMotorRenewal/Policy_Detail", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
