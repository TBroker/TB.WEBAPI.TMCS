using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class CarColorListResponse
    {
        [JsonPropertyName("COLOUR_CODE")]
        public string? ColorCode { get; set; }

        [JsonPropertyName("COLOUR_NAME")]
        public string? ColorName { get; set; }
    }
}