using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Quotations
{
    public class QuotationDetailRequest
    {
        [JsonPropertyName("QUOTATION_NO")]
        [Description("เลขที่ใบเสนอราคา")]
        public string? QuotationNo { get; set; }
    }
}