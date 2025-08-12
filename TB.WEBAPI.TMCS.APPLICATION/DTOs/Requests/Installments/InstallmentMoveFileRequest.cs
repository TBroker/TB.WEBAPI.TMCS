using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Installments
{
    public class InstallmentMoveFileRequest
    {
        [JsonPropertyName("CONT_NO")]
        [Description("เลขที่สัญญา")]
        public string ContactNo { get; set; } = ""; 

        [JsonPropertyName("APP_VOLNO")]
        [Description("เลขที่ใบคำขอภาคสมัครใจ 18 หลัก")]
        public string ApplicationVoluntaryNo { get; set; } = "";
    }
}
