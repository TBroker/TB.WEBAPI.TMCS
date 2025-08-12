using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class CarBrandListResponse
    {
        [JsonPropertyName("CARBRAND_CODE")]
        public string? CarBrandCode { get; set; }

        [JsonPropertyName("CARBRAND_NAME")]
        public string? CarBrandName { get; set; }
    }
}