using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Requests.Compulsories
{
    public class CompulsoryCommissionRequest
    {
        [JsonPropertyName("APPNO_COM")]
        public string? AppNoCMI { get; set; }
    }
}