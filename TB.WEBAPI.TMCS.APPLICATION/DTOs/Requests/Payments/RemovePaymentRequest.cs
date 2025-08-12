using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Payments
{
    public class RemovePaymentRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("APPNO_VOL")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("APPNO_COM")]
        public string? AppNoCMI { get; set; }
    }
}
