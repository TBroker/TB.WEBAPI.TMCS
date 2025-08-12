using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Installments
{
    public class InstallmentDetailRequest
    {
        [JsonPropertyName("APP_NO")]
        [Description("เลขใบคำขอ")]
        public string? AppNo { get; set; }
    }
}
