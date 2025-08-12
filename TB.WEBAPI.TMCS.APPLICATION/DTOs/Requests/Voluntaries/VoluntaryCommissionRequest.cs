using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Voluntaries
{
    public class VoluntaryCommissionRequest
    {
        [JsonPropertyName("APPNO_VOL")]
        [Description("เลขใบคำขอสมัครใจ")]
        public string? ApplicationNoVoluntary { get; set; }
    }
}