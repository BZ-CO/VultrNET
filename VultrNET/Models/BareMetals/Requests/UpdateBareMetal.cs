using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals.Requests
{
    public class UpdateBareMetal
    {
        public UpdateBareMetal(
            string? userData = null,
            string? label = null,
            int? osId = null,
            int? appID = null,
            string? imageId = null,
            bool? enableIPv6 = null,
            List<string>? tags = null)
        {
            UserData = userData;
            Label = label;
            OSId = osId;
            AppID = appID;
            ImageId = imageId;
            EnableIPv6 = enableIPv6;
            Tags = tags;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("user_data")]
        public string? UserData { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public string? Label { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("os_id")]
        public int? OSId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("app_id")]
        public int? AppID { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("image_id")]
        public string? ImageId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enable_ipv6")]
        public bool? EnableIPv6 { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; }
    }
}