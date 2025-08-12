using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Compulsories;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Compulsories;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/compulsory/")]
    [ApiController]
    public class CompulsoryController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("fetch/commission")]
        public async Task<IActionResult> FetchCompulsoryCommission([FromBody] CompulsoryCommissionRequest request)
        {
            var response = await _apiClientService.PostAsync<CompulsoryCommissionRequest, IEnumerable<CompulsoryCommissionResponse>>("/apiPayment/GetComm_CMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/policy/detail")]
        public async Task<IActionResult> FetchCompulsoryPolicyDetail(CompulsoryPolicyDetailRequest request)
        {
            var response = await _apiClientService.PostAsync<CompulsoryPolicyDetailRequest, IEnumerable<CompulsoryPolicyDetailResponse>>("/apiMotorRenewal/Policy_CMIDetail", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/premium")]
        public async Task<IActionResult> FetchCompulsoryPremium([FromBody] CompulsoryPremiumRequest request)
        {
            var response = await _apiClientService.PostAsync<CompulsoryPremiumRequest, IEnumerable<CompulsoryPremiumResponse>>("/apiMaster/cop_Premium", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}