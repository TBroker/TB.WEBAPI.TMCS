using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Motors
{
    public class MotorSubmitResponse
    {
        [JsonPropertyName("VOLAPPNO")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("COPAPPNO")]
        public string? AppNoCMI { get; set; }
    }
}
