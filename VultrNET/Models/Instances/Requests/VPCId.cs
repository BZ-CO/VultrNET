using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class VPCId
    {
        public VPCId(string id)
        {
            Id = id;
        }

        [JsonPropertyName("vpc_id")]
        public string Id { get; }
    }
}