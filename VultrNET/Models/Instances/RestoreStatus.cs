using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class RestoreStatus
    {
        public RestoreStatus(string restoreType, string restoreId, string status)
        {
            RestoreType = restoreType;
            RestoreId = restoreId;
            Status = status;
        }

        [JsonPropertyName("restore_type")]
        public string RestoreType { get; }

        [JsonPropertyName("restore_id")]
        public string RestoreId { get; }

        [JsonPropertyName("status")]
        public string Status { get; }
    }
}