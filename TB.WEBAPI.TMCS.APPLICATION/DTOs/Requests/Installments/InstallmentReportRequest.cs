using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Installments
{
    public class InstallmentReportRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        [Description("รหัสตัวแทน")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("SEARCH_FROM")]
        [Description("เงื่อนไขการค้นหา")]
        public string? SearchFrom { get; set; }

        [JsonPropertyName("START_DATE")]
        [Description("วันที่เริ่ม")]
        public string? StartDate { get; set; }

        [JsonPropertyName("END_DATE")]
        [Description("วันที่สิ้นสุด")]
        public string? EndDate { get; set; }

        [JsonPropertyName("APP_NO")]
        [Description("เลขที่ใบคำขอ")]
        public string? AppNo { get; set; }

        [JsonPropertyName("POLICY_NO")]
        [Description("เลขกรมธรรม์")]
        public string? PolicyNo { get; set; }

        [JsonPropertyName("INS_SURNAME")]
        [Description("ชื่อ-สกุลลูกค้า")]
        public string? InsSurname { get; set; }

        [JsonPropertyName("CAR_REGNO")]
        [Description("เลขทะเบียนรถ")]
        public string? CarRegNo { get; set; }
    }
}
