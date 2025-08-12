using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Installments
{
    public class InstallmentQrCodeDetailRequest
    {
        [JsonPropertyName("APP_NO")]
        [Description("เลขที่ใบคำขอ")]
        public string? AppNo { get; set; }
    }
}
