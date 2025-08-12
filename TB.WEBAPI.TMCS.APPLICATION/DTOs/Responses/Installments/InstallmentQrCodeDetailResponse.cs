using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Installments
{
    public class InstallmentQrCodeDetailResponse
    {
        [JsonPropertyName("APP_NO")]
        public string? AppNo { get; set; }

        [JsonPropertyName("INSTALLMENT_NO")]
        public int? InstallmentNo { get; set; }

        [JsonPropertyName("INS_NAME")]
        public string? InsName { get; set; }

        [JsonPropertyName("ADDR")]
        public string? Addr { get; set; }

        [JsonPropertyName("SUBDISTRIC")]
        public string? SubDistrict { get; set; }

        [JsonPropertyName("DISTRICT_NAME_T")]
        public string? DistrictNameT { get; set; }

        [JsonPropertyName("PROV_NAME_T")]
        public string? ProvinceNameTh { get; set; }

        [JsonPropertyName("ZIPCODE")]
        public string? ZipCode { get; set; }

        [JsonPropertyName("CARREG_NO")]
        public string? CarRegNo { get; set; }

        [JsonPropertyName("RECEIPT_DATE")]
        public string? ReceiptDate { get; set; }

        [JsonPropertyName("DUEDATE")]
        public string? DueDate { get; set; }

        [JsonPropertyName("PAYAS")]
        public string? PayAs { get; set; }

        [JsonPropertyName("TOTAL_PREM_AMT")]
        public double? TotalPremAmt { get; set; }

        [JsonPropertyName("PHONE_NO")]
        public string? PhoneNo { get; set; }
    }
}
