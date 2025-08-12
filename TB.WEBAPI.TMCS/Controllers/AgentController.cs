using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Agents;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Agents;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/agent/")]
    [ApiController]
    public class AgentController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("fetch/detail")]
        public async Task<IActionResult> FetchAgentDetail([FromBody] AgentDetailRequest request)
        {
            var response = await _apiClientService.PostAsync<AgentDetailRequest, IEnumerable<AgentDetailResponse>>("/apiMaster/agent", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}