using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Policies
{
    public class PolicyReportResponse
    {
        [JsonPropertyName("AGENT_CODE")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("QUOTE_NO")]
        public string? QutationNo { get; set; }

        [JsonPropertyName("NAME_LASTNAME")]
        public string? FullName { get; set; }

        [JsonPropertyName("VEHICLE_NO")]
        public string? VehicleNo { get; set; }

        [JsonPropertyName("APPNO_VOL")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("POLICYNO_VOL")]
        public string? PolicyNoVMI { get; set; }

        [JsonPropertyName("DATE_CREATE_VOL")]
        public string? DateCreateVMI { get; set; }

        [JsonPropertyName("POLICY_TYPE_VOL")]
        public string? PolicyTypeVMI { get; set; }

        [JsonPropertyName("PRODUCT_VOL")]
        public string? ProductVMI { get; set; }

        [JsonPropertyName("NET_PREM_AMT_VOL")]
        public int NetPremAmountVMI { get; set; }

        [JsonPropertyName("STAMP_DUTY_AMT_VOL")]
        public int StampDutyAmountVMI { get; set; }

        [JsonPropertyName("VAT_AMT_VOL")]
        public double VatAmountVMI { get; set; }

        [JsonPropertyName("TOTAL_PREM_AMT_VOL")]
        public double TotalPremAmountVMI { get; set; }

        [JsonPropertyName("FLG_NEW_RENEW_VOL")]
        public string? FlagNewRenewVMI { get; set; }

        [JsonPropertyName("RENEWAL_FROM_VOL")]
        public string? RenewalFromVMI { get; set; }

        [JsonPropertyName("APPNO_COM")]
        public string? AppNoCMI { get; set; }

        [JsonPropertyName("POLICY_NO_COM")]
        public string? PolicyNoCMI { get; set; }

        [JsonPropertyName("DATE_CREATE_COM")]
        public string? DateCreateCMI { get; set; }

        [JsonPropertyName("POLICY_TYPE_COM")]
        public string? PolicyTypeCMI { get; set; }

        [JsonPropertyName("PRODUCT_COM")]
        public string? ProductCMI { get; set; }

        [JsonPropertyName("NET_PREM_AMT_COM")]
        public object? NetPremAmountCMI { get; set; }

        [JsonPropertyName("STAMP_DUTY_AMT_COM")]
        public object? StampDutyAmountCMI { get; set; }

        [JsonPropertyName("VAT_AMT_COM")]
        public object? VatAmountCMI { get; set; }

        [JsonPropertyName("TOTAL_PREM_AMT_COM")]
        public object? TotalPremAmountCMI { get; set; }

        [JsonPropertyName("FLG_NEW_RENEW_COM")]
        public string? FlagNewRenewCMI { get; set; }

        [JsonPropertyName("RENEWAL_FROM_COM")]
        public string? RenewalFromCMI { get; set; }
    }
}