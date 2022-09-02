using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class BareMetalIPv4Addresses
    {
        public BareMetalIPv4Addresses(List<IPv4> ipv4Addresses, Meta meta)
        {
            IPv4Addresses = ipv4Addresses;
            Meta = meta;
        }

        [JsonPropertyName("ipv4s")] public List<IPv4> IPv4Addresses { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}