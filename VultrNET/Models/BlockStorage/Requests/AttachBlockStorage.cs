using System.Text.Json.Serialization;

namespace VultrNET.Models.BlockStorage.Requests
{
    public class AttachBlockStorage
    {
        public AttachBlockStorage(string instanceId, bool? live = null)
        {
            InstanceId = instanceId;
            Live = live;
        }

        [JsonPropertyName("instance_id")] public string InstanceId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("live")]
        public bool? Live { get; }
    }
}