using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Agents
{
    public class AgentDetailRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        [Description("รหัสตัวแทน")]
        public string? AgentCode { get; set; }
    }
}