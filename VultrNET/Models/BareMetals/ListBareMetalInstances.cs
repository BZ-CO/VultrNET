using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class ListBareMetalInstances
    {
        public ListBareMetalInstances(List<BareMetal> bareMetals, Meta meta)
        {
            BareMetals = bareMetals;
            Meta = meta;
        }

        [JsonPropertyName("bare_metals")] public List<BareMetal> BareMetals { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}