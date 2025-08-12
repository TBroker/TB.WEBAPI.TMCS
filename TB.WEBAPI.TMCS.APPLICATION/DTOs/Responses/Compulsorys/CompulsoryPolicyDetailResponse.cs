using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Compulsorys
{
    public class CompulsoryPolicyDetailResponse
    {
        [JsonPropertyName("POLICY_NO_CMI")]
        public string? PolicyNoCMI { get; set; }

        [JsonPropertyName("POL_MAKE_DATE")]
        public string? PolicyCreateDate { get; set; }

        [JsonPropertyName("INS_START_DATE")]
        public string? StartDate { get; set; }

        [JsonPropertyName("INS_END_DATE")]
        public string? EndDate { get; set; }

        [JsonPropertyName("APP_NO_CMI")]
        public string? AppNoCMI { get; set; }

        [JsonPropertyName("APP_NO_VMI")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("COMPANY_CODE")]
        public string? CompanyCode { get; set; }
    }
}