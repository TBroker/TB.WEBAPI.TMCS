using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Masters
{
    public class AddressDistrictRequest
    {
        [JsonPropertyName("PROVINCE_CODE")]
        [Description("รหัสจังหวัด")]
        public string? ProvinceCode { get; set; }
    }
}