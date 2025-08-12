using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Policies;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Policies;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/policy/")]
    [ApiController]
    public class PolicyController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("create/compulsory")]
        public async Task<IActionResult> CreatePolicyCompulsory([FromBody] IssuePolicyCompulsoryRequest request)
        {
            var response = await _apiClientService.PostAsync<IssuePolicyCompulsoryRequest, IEnumerable<IssuePolicyCompulsoryResponse>>("/apiMotorCMI/TMCSToInsurer_CMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("create/voluntary")]
        public async Task<IActionResult> CreatePolicyVoluntary([FromBody] IssuePolicyVoluntaryRequest request)
        {
            var response = await _apiClientService.PostAsync<IssuePolicyVoluntaryRequest, IEnumerable<IssuePolicyVolResponse>>("/apiMotorVMI/TMCSToInsurer_VMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/report")]
        public async Task<IActionResult> FetchPolicyReport([FromBody] PolicyReportRequest request)
        {
            var response = await _apiClientService.PostAsync<PolicyReportRequest, IEnumerable<PolicyReportResponse>>("/apiMotorVMI/Report_Policy", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}