using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Compulsories
{
    public class CompulsoryPolicyDetailRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        [Description("รหัสตัวแทน")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("POLICY_NO_CMI")]
        [Description("เลขกรมธรรม์ภาคบังคับ")]
        public string? PolicyNoCMI { get; set; }
    }
}