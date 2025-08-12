using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Payments
{
    public class PaymentReportResponse
    {
        [JsonPropertyName("AGENT_CODE")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("DATE_PAID")]
        public string? DatePaid { get; set; }

        [JsonPropertyName("APPNO_VOL")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("FLG_NEW_RENEW")]
        public string? FlagNewRenew { get; set; }

        [JsonPropertyName("RENEWAL_FROM")]
        public string? RenewFrom { get; set; }

        [JsonPropertyName("TOTAL_VOL")]
        public decimal TotalVMI { get; set; }

        [JsonPropertyName("APPNO_COM")]
        public string? AppNoCMI { get; set; }

        [JsonPropertyName("TOTAL_COM")]
        public decimal TotalCMI { get; set; }

        [JsonPropertyName("POLICY_TYPE")]
        public string? PolicyType { get; set; }

        [JsonPropertyName("PRODUCT")]
        public string? ProductCode { get; set; }

        [JsonPropertyName("NAME_LASTNAME")]
        public string? FullName { get; set; }

        [JsonPropertyName("VEHICLE_NO")]
        public string? VehicleNo { get; set; }

        [JsonPropertyName("COMMISSION_TYPE")]
        public string? CommissionType { get; set; }

        [JsonPropertyName("STATUS_PAID")]
        public string? StatusPaid { get; set; }

        [JsonPropertyName("SUBPOLICY")]
        public string? SubPolicy { get; set; }

        [JsonPropertyName("QUOTE_NO")]
        public string? QuotationNo { get; set; }

        [JsonPropertyName("POLICYNO_VOL")]
        public string? PolicyVMI { get; set; }

        [JsonPropertyName("POLICYNO_COM")]
        public string? PolicyCMI { get; set; }

        [JsonPropertyName("MAIN_SUBINS_TYPE")]
        public string? MainSubinsType { get; set; }

        [JsonPropertyName("ORDER_ID")]
        public string? OrderID { get; set; }

        [JsonPropertyName("CHANNEL_PAY")]
        public string? ChannelPay { get; set; }
    }
}