using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class CarUsedListResponse
    {
        [JsonPropertyName("CARUSED_CODE")]
        public string? CarUsedCode { get; set; }

        [JsonPropertyName("CARUSED_DESC")]
        public string? CarUsedDescription { get; set; }
    }
}