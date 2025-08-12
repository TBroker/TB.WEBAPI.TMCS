using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Compulsories
{
    public class CompulsoryPremiumRequest
    {
        [JsonPropertyName("CAR_CODE_VOL")]
        [Description("รหัสรถยนต์สมัครใจ")]
        public string? CarCodeVoluntary { get; set; }
    }
}