using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Payments;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Payments;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/payment/")]
    [ApiController]
    public class PaymentController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("create/transaction")]
        public async Task<IActionResult> CreateTransactionPayment([FromBody] CreateTransactionPaymentRequest request)
        {
            var response = await _apiClientService.PostAsync<CreateTransactionPaymentRequest, ApiResponseDtoCoreSystem>("/apiPayment/PaymentGateway_ini", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("fetch/report")]
        public async Task<IActionResult> FetchPaymentReport([FromBody] PaymentReportRequest request)
        {
            var response = await _apiClientService.PostAsync<PaymentReportRequest, IEnumerable<PaymentReportResponse>>("/apiPayment/Report_Payment", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("modify/ref/compulsory")]
        public async Task<IActionResult> ModifyReferencePaymentCompulsory([FromBody] UpdatePaymentRefRequest request)
        {
            var response = await _apiClientService.PostAsync<UpdatePaymentRefRequest, ApiResponseDtoCoreSystem>("/apiMotorCMI/Update_ChannelRef_CMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("modify/ref/voluntary")]
        public async Task<IActionResult> ModifyReferencePaymentVoluntary([FromBody] UpdatePaymentRefRequest request)
        {
            var response = await _apiClientService.PostAsync<UpdatePaymentRefRequest, ApiResponseDtoCoreSystem>("/apiMotorVMI/Update_ChannelRef_VMI", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("modify/transaction")]
        public async Task<IActionResult> ModifyTransactionPayment([FromBody] UpdateTransactionPaymentRequest request)
        {
            var response = await _apiClientService.PostAsync<UpdateTransactionPaymentRequest, ApiResponseDtoCoreSystem>("/apiPayment/PaymentGateway_update", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }

        [HttpPost("remove/transaction")]
        public async Task<IActionResult> RemoveTransactionPayment([FromBody] RemovePaymentRequest request)
        {
            var response = await _apiClientService.PostAsync<RemovePaymentRequest, ApiResponseDtoCoreSystem>("/apiMotorVMI/Delete_ApplNotPaid", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
