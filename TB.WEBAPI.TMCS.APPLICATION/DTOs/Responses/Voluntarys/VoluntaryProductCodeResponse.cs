using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Voluntarys
{
    public class VoluntaryProductCodeResponse
    {
        [JsonPropertyName("DATA_GROUP_CODE")]
        public string? DataGroupCode { get; set; }

        [JsonPropertyName("SUBINS_TYPE")]
        public string? SubInsureType { get; set; }

        [JsonPropertyName("DATA_TYPE_DESC")]
        public string? DataTypeDescription { get; set; }

        [JsonPropertyName("INS_COMPANY_CODE")]
        public string? InsureCompanyCode { get; set; }

        [JsonPropertyName("INS_PRODUCT_CODE")]
        public string? InsureProductCode { get; set; }

        [JsonPropertyName("INS_PRODUCT_DESC")]
        public string? InsureProductDesc { get; set; }
    }
}