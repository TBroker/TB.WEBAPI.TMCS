using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Payments
{
    public class UpdateTransactionPaymentRequest
    {
        [JsonPropertyName("ORDER_ID")]
        public string? OrderId { get; set; }

        [JsonPropertyName("STATUS_PAID")]
        public string? StatusPaid { get; set; }

        [JsonPropertyName("DATE_UPDATE")]
        public string? DateUpdate { get; set; }
    }
}