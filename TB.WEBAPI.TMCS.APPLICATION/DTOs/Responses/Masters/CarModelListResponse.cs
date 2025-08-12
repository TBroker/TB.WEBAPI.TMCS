using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class CarModelListResponse
    {
        [JsonPropertyName("CARBRAND_CODE")]
        public string? CarBrandCode { get; set; }

        [JsonPropertyName("CARBRAND_NAME")]
        public string? CarBrandName { get; set; }

        [JsonPropertyName("CARMODEL_CODE")]
        public string? CarModelCode { get; set; }

        [JsonPropertyName("CARMODEL_NAME")]
        public string? CarModelName { get; set; }
    }
}