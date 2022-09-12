using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class RestoreInstance
    {
        public RestoreInstance(RestoreStatus status)
        {
            Status = status;
        }

        [JsonPropertyName("status")] public RestoreStatus Status { get; }
    }
}