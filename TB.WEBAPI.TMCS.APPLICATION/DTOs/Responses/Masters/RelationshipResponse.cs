using System.Text.Json.Serialization;

namespace TB.WEBAPI.TMCS.APPLICATION.DTOs.Responses.Masters
{
    public class RelationshipResponse
    {
        [JsonPropertyName("INS_RELATION_CODE")]
        public string RelationshipCode { get; set; } = string.Empty;

        [JsonPropertyName("INS_RELATIONSHIPS")]
        public string RelationshipName { get; set; } = string.Empty;
    }
}