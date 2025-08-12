using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class AddressProvinceListResponse
    {
        [JsonPropertyName("PROVINCE_CODE")]
        public string? ProvinceCode { get; set; }

        [JsonPropertyName("PROV_NAME_T")]
        public string? ProvinceName { get; set; }
    }
}