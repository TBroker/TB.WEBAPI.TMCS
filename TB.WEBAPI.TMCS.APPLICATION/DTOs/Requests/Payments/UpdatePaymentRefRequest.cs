using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Payments
{
    public class UpdatePaymentRefRequest
    {
        [JsonPropertyName("APP_NO")]
        public string? AppNo { get; set; }
        [JsonPropertyName("CHANNEL_REF1")]
        public string? Reference1 { get; set; }
        [JsonPropertyName("CHANNEL_REF2")]
        public string? Reference2 { get; set; }
    }
}
