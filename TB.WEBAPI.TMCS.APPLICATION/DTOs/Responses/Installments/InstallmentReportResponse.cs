using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Installments
{
    public class InstallmentReportResponse
    {
        [JsonPropertyName("AGENT_CODE")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("AGENT_NAME")]
        public string? AgentName { get; set; }

        [JsonPropertyName("APP_NO")]
        public string? AppNo { get; set; }

        [JsonPropertyName("POLICY_NO")]
        public string? PolicyNo { get; set; }

        [JsonPropertyName("COMPANY_CODE")]
        public string? CompanyCode { get; set; }

        [JsonPropertyName("INS_COMP_NAME_T")]
        public string? InsCompanyNameT { get; set; }

        [JsonPropertyName("INS_NAME")]
        public string? InsName { get; set; }

        [JsonPropertyName("INS_START_DATE")]
        public string? InsStartDate { get; set; }

        [JsonPropertyName("INS_END_DATE")]
        public string? InsEndDate { get; set; }

        [JsonPropertyName("CARREG_NO")]
        public string? CarRegNo { get; set; }

        [JsonPropertyName("SUM_TOTAL_PREM_AMT")]
        public double? SumTotalPremAmt { get; set; }

        [JsonPropertyName("INSTALLMENT")]
        public int? Installment { get; set; }

        [JsonPropertyName("TOTAL_PREM_AMT")]
        public double? TotalPremAmt { get; set; }

        [JsonPropertyName("NUM_INSTL_PAYIN")]
        public int? NumInstlPayin { get; set; }

        [JsonPropertyName("SUM_PAYIN_AMT")]
        public double? SumPayinAmt { get; set; }

        [JsonPropertyName("NUM_INSTL_NOT_PAYIN")]
        public int? NumInstlNotPayin { get; set; }

        [JsonPropertyName("SUM_NOT_PAYIN_AMT")]
        public double? SumNotPayinAmt { get; set; }

        [JsonPropertyName("DUEDATE")]
        public string? Duedate { get; set; }

        [JsonPropertyName("DUEDATE_INSTALLMENT_NO")]
        public int? DuedateInstallmentNo { get; set; }

        [JsonPropertyName("POLICY_STATUS")]
        public string? PolicyStatus { get; set; }
    }
}
