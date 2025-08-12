using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs
{
    public class ApiResponseDtoCoreSystem
    {
        [JsonPropertyName("Result")]
        public string? Result { get; set; }

        [JsonPropertyName("ErrorMsg")]
        public string? ErrorMessage { get; set; }

        [JsonPropertyName("TransDateTime")]
        public string? TransDateTime { get; set; }
    }

    public class SubmitMotorResponse : ApiResponseDtoCoreSystem
    {
        [JsonPropertyName("VolAppNo")]
        public string? AppNoVMI { get; set; }

        [JsonPropertyName("CopAppNo")]
        public string? AppNoCMI { get; set; }
    }

    public class PaymentResponse : ApiResponseDtoCoreSystem
    {
        [JsonPropertyName("OrderId")]
        public string? OrderId { get; set; }
    }
}