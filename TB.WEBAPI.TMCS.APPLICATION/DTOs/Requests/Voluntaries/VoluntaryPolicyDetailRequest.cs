using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Voluntaries
{
    public class VoluntaryPolicyDetailRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        [Description("รหัสตัวแทน")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("POLICY_NO_VMI")]
        [Description("เลขกรมธรรม์สมัครใจ")]
        public string? PolicyNoVMI { get; set; }
    }
}