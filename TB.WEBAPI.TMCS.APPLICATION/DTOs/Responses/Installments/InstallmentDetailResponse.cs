using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Installments
{
    public class InstallmentDetailResponse
    {
        [JsonPropertyName("APP_NO")]
        public string? AppNo { get; set; }

        [JsonPropertyName("POLICY_NO")]
        public string? PolicyNo { get; set; }

        [JsonPropertyName("INS_COMP_CODE")]
        public string? InsCompCode { get; set; }

        [JsonPropertyName("INS_COMP_NAME")]
        public string? InsCompName { get; set; }

        [JsonPropertyName("POLICY_STATUS")]
        public string? PolicyStatus { get; set; }

        [JsonPropertyName("INS_NAME")]
        public string? InsName { get; set; }

        [JsonPropertyName("INS_TELEPHONE")]
        public string? InsTelephone { get; set; }

        [JsonPropertyName("CARREG_NO")]
        public string? CarRegNo { get; set; }

        [JsonPropertyName("INS_START_DATE")]
        public string? InsStartDate { get; set; }

        [JsonPropertyName("INS_END_DATE")]
        public string? InsEndDate { get; set; }

        [JsonPropertyName("SUM_PREM_AMT")]
        public double? SumPremAmt { get; set; }

        [JsonPropertyName("SUM_PAYIN_AMT")]
        public double? SumPayinAmt { get; set; }

        [JsonPropertyName("SUM_BAL_AMT")]
        public double? SumBalAmt { get; set; }

        [JsonPropertyName("REMARK")]
        public string? Remark { get; set; }

        [JsonPropertyName("LAST_PAYIN_INSTALLMENT_NO")]
        public int? LastPayinInstallmentNo { get; set; }

        [JsonPropertyName("DATA")]
        public List<InstallmentData>? Data { get; set; }
    }

    public class InstallmentData
    {
        [JsonPropertyName("INSTALLMENT_NO")]
        public string? InstallmentNo { get; set; }

        [JsonPropertyName("TOTAL_PREM_AMT")]
        public double? TotalPremAmt { get; set; }

        [JsonPropertyName("DUEDATE")]
        public string? Duedate { get; set; }

        [JsonPropertyName("PAY_IN_AMT")]
        public double? PayInAmt { get; set; }

        [JsonPropertyName("PAY_IN_DATE")]
        public string? PayInDate { get; set; }

        [JsonPropertyName("FLAG_CANCEL")]
        public string? FlagCancel { get; set; }

        [JsonPropertyName("STATUS")]
        public string? Status { get; set; }
    }
}