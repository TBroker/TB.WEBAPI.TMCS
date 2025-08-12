using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Motors;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/motor/")]
    [ApiController]
    public class MotorController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("submit/motor")]
        public async Task<IActionResult> CreateSubmitMotor([FromBody] MotorSubmitRequest request)
        {
            var response = await _apiClientService.PostAsync<MotorSubmitRequest, ApiResponseDtoCoreSystem>("/apiMotorVMI/ApplMotorVMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("submit/motor/upload")]
        public async Task<IActionResult> CreateSubmitMotorUploadFile([FromBody] MotorUploadFileRequest request)
        {
            var response = await _apiClientService.PostAsync<MotorUploadFileRequest, ApiResponseDtoCoreSystem>("/apiMotorVMI/AttachFileVol", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}