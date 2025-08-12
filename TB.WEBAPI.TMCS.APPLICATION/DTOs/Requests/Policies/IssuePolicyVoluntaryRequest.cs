using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Policies
{
    public class IssuePolicyVoluntaryRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("INS_COMPANY_CODE")]
        public string? InsureCompanyCode { get; set; }

        [JsonPropertyName("APP_VOLNO")]
        public string? ApplicationNoVoluntary { get; set; }
    }
}
