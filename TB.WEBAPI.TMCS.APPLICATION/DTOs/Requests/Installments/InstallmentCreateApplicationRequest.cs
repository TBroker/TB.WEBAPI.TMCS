using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Installments
{
    public class InstallmentCreateApplicationRequest
    {
        [JsonPropertyName("AGENT_CODE")]
        [Description("รหัสตัวแทน")]
        public string AgentCode { get; set; } = "";

        [JsonPropertyName("APP_VOLNO")]
        [Description("เลขที่ใบคำขอภาคสมัครใจ 18 หลัก")]
        public string ApplicationVoluntaryNo { get; set; } = "";

        [JsonPropertyName("NUM_INSTALL")]
        [Description("จำนวนงวด")]
        public int NumberInstall { get; set; }

        [JsonPropertyName("TEL_NUMBER_INSTALL")]
        [Description("เบอร์โทรอ้างอิง สำหรับผ่อนชำระ")]
        public string MobileInstallment { get; set; } = "";

        [JsonPropertyName("CONT_NO")]
        [Description("เลขที่สัญญา")]
        public string ContactNo { get; set; } = "";

        [JsonPropertyName("LINE_INSURANCE")]
        [Description("Line id ผู้เอาประกันภัย")]
        public string LineInsurance { get; set; } = "-";
    }
}
