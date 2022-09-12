using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class BandwidthHistory
    {
        public BandwidthHistory(Dictionary<string, Bandwidth> bandwidth)
        {
            Bandwidth = bandwidth;
        }

        [JsonPropertyName("bandwidth")] public Dictionary<string, Bandwidth> Bandwidth { get; }
    }
}