using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Compulsorys
{
    public class CompulsoryPremiumResponse
    {
        [JsonPropertyName("CAR_CODE_VOL")]
        public string? CarCodeVMI { get; set; }

        [JsonPropertyName("CAR_CODE_COP")]
        public string? CarCodeCMI { get; set; }

        [JsonPropertyName("CARSUB_CODE_COP")]
        public string? CarSubCodeCMI { get; set; }

        [JsonPropertyName("CARTYPE_CODE")]
        public string? CarTypeCode { get; set; }

        [JsonPropertyName("CARUSED_CODE")]
        public string? CarUseCode { get; set; }

        [JsonPropertyName("PREMIUM_COP")]
        public int PremiumsCMI { get; set; }

        [JsonPropertyName("STAM_COP")]
        public int StamCMI { get; set; }

        [JsonPropertyName("VAT_COP")]
        public double VatCMI { get; set; }

        [JsonPropertyName("SUM_PREMIUM")]
        public double SumPremiums { get; set; }

        [JsonPropertyName("TYPE_CAR")]
        public string? TypeCar { get; set; }
    }
}