using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class AttachISO
    {
        public AttachISO(string isoId)
        {
            IsoId = isoId;
        }

        [JsonPropertyName("iso_id")]
        public string IsoId { get; }
    }
}