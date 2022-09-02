using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class GetBareMetalBandwidth
    {
        public GetBareMetalBandwidth(Dictionary<string, Bandwidth> bandwidth)
        {
            Bandwidth = bandwidth;
        }

        [JsonPropertyName("bandwidth")] public Dictionary<string, Bandwidth> Bandwidth { get; }
    }
}