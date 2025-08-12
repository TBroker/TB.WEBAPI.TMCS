using Microsoft.AspNetCore.Mvc;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Quotations;
using TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Quotations;
using TB.WEBAPI.TMCS.APPLICATION.Interfaces;

namespace TB.WEBAPI.TMCS.Controllers
{
    [Route("api/quotation/")]
    [ApiController]
    public class QuotationController(IApiClientService apiClientService) : ControllerBase
    {
        private readonly IApiClientService _apiClientService = apiClientService;

        [HttpPost("fetch/detail")]
        public async Task<IActionResult> FetchQuotationDetail(QuotationDetailRequest request)
        {
            var response = await _apiClientService.PostAsync<QuotationDetailRequest, IEnumerable<QuotationDetailResponse>>("/apiMotorVMI/Report_Quotation", request);
            return response.Code == 200 ? Ok(response) : BadRequest(response);
        }
    }
}
