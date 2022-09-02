using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class BareMetalIPv6Addresses
    {
        public BareMetalIPv6Addresses(List<IPv6> ipv6Addresses, Meta meta)
        {
            IPv6Addresses = ipv6Addresses;
            Meta = meta;
        }

        [JsonPropertyName("ipv6s")] public List<IPv6> IPv6Addresses { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}