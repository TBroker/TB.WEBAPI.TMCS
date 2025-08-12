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

        [HttpPost("fetch/report")]
        public async Task<IActionResult> FetchPolicyReport([FromBody] PolicyReportRequest request)
        {
            var response = await _apiClientService.PostAsync<PolicyReportRequest, IEnumerable<PolicyReportResponse>>("/apiMotorVMI/Report_Policy", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("create/voluntary")]
        public async Task<IActionResult> CreatePolicyVoluntary([FromBody] IssuePolicyVolRequest request)
        {
            var response = await _apiClientService.PostAsync<IssuePolicyVolRequest, IEnumerable<IssuePolicyVolResponse>>("/apiMotorVMI/TMCSToInsurer_VMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("create/compulsory")]
        public async Task<IActionResult> CreatePolicyCompulsory([FromBody] IssuePolicyComRequest request)
        {
            var response = await _apiClientService.PostAsync<IssuePolicyComRequest, IEnumerable<IssuePolicyComResponse>>("/apiMotorCMI/TMCSToInsurer_CMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
