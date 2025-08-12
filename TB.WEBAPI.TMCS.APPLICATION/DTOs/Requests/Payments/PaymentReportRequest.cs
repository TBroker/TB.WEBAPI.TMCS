using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Payments
{
    public class PaymentReportRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        [Description("รหัสตัวแทน")]
        public string? AgentCode { get; set; }

        [JsonPropertyName("DATE_PAIDSTART")]
        [Description("วันที่เริ่มชำระ")]
        public string? DatePaidStart { get; set; }

        [JsonPropertyName("DATE_PAIDEND")]
        [Description("วันที่สิ้นสุดชำระ")]
        public string? DatePaidEnd { get; set; }

        [JsonPropertyName("VEHICLE_NO")]
        [Description("ทะเบียนรถยนต์")]
        public string? VehicleNo { get; set; }

        [JsonPropertyName("STATUS_PAID")]
        [Description("สถานะการชำระ")]
        public string? StatusPaid { get; set; }

        [JsonPropertyName("SELECT_VOL_COM")]
        [Description("เลือกภาคสมัครใขหรือภาคบังคับ")]
        public string? SelectVmiCmi { get; set; }

        [JsonPropertyName("POLICY_TYPE")]
        [Description("ประเภทกรมธรรม์")]
        public string? PolicyType { get; set; }

        [JsonPropertyName("NAME_LASTNAME")]
        [Description("ชื่อ-นามสกุลลูกค้า")]
        public string? FullName { get; set; }

        [JsonPropertyName("APPNO_VOL")]
        [Description("เลขที่ใบคำขอภาคสมัครใจ")]
        public string? AppNoVmi { get; set; }

        [JsonPropertyName("APPNO_COM")]
        [Description("เลขที่ใบคำขอภาคบังคับ")]
        public string? AppNoCmi { get; set; }
    }
}