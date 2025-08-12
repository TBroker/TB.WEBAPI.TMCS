using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Installments;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Installments;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/installment/")]
    [ApiController]
    public class InstallmentController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("fetch/report")]
        public async Task<IActionResult> FetchInstallmentReport([FromBody] InstallmentReportRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentReportRequest, IEnumerable<InstallmentReportResponse>>("/apiInstallment/Report_Installment", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/detail")]
        public async Task<IActionResult> FetchInstallmentDetail([FromBody] InstallmentDetailRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentDetailRequest, IEnumerable<InstallmentDetailResponse>>("/apiInstallment/Appl_Installment", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/qrcode/detail")]
        public async Task<IActionResult> FetchInstallmentQrCodeDetail([FromBody] InstallmentQrCodeDetailRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentQrCodeDetailRequest, IEnumerable<InstallmentQrCodeDetailResponse>>("/apiInstallment/QRCode_Installment", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/calculate/period")]
        public async Task<IActionResult> FetchInstallmentQrCodeReport([FromBody] InstallmentCalculatePeriodRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentCalculatePeriodRequest, IEnumerable<InstallmentCalculatePeriodResponse>>("/apiInstallment/CalNotsave_Installment", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("create/file/upload")]
        public async Task<IActionResult> CreateSubmitMotorUploadFile([FromBody] InstallmentUploadFileRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentUploadFileRequest, IEnumerable<ApiResponseDtoCoreSystem>>("/apiInstallment/AttachContract", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("modify/file/upload")]
        public async Task<IActionResult> ModifySubmitMotorUploadFile([FromBody] InstallmentMoveFileRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentMoveFileRequest, IEnumerable<ApiResponseDtoCoreSystem>>("/apiInstallment/ChangeDirContToAppl", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("create/application")]
        public async Task<IActionResult> CreateInstallmentApplication([FromBody] InstallmentCreateApplicationRequest request)
        {
            var response = await _apiClientService.PostAsync<InstallmentCreateApplicationRequest, IEnumerable<ApiResponseDtoCoreSystem>>("/apiInstallment/CreatInstallmentVMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}