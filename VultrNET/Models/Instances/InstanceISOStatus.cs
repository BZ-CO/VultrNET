using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class InstanceISOStatus
    {
        public InstanceISOStatus(ISOStatus isoStatus)
        {
            IsoStatus = isoStatus;
        }

        [JsonPropertyName("iso_status")] public ISOStatus IsoStatus { get; }
    }
}