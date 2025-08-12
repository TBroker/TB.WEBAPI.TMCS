using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class CarComCodeListResponse
    {
        [JsonPropertyName("CAR_CODE")]
        public string? CarCode { get; set; }
    }
}