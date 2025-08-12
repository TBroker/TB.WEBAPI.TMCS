using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Voluntaries
{
    public class VoluntaryProductCodeRequest
    {
        [JsonPropertyName("INS_COMPANY_CODE")]
        [Description("รหัสบริษัทประกันภัย")]
        public string? InsureCompanyCode { get; set; }
    }
}