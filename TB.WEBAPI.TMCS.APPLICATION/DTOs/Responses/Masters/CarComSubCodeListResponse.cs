using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class CarComSubCodeListResponse
    {
        [JsonPropertyName("CAR_CODE")]
        public string? CarCode { get; set; }

        [JsonPropertyName("CARSUB_CODE")]
        public string? CarSubCode { get; set; }
    }
}