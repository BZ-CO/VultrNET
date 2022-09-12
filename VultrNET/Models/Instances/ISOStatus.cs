using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class ISOStatus
    {
        public ISOStatus(string status, string isoId)
        {
            Status = status;
            IsoId = isoId;
        }

        [JsonPropertyName("status")]
        public string Status { get; }

        [JsonPropertyName("iso_id")]
        public string IsoId { get; }
    }
}