using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Masters
{
    public class CarComSubCodeRequest
    {
        [JsonPropertyName("CAR_CODE")]
        [Description("รหัสรถยนต์ภาคบังคับ")]
        public string? CarCode { get; set; }
    }
}