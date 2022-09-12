using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class ListIPv6Information
    {
        public ListIPv6Information(List<IPv6> ipv6s, Meta meta)
        {
            IPv6s = ipv6s;
            Meta = meta;
        }

        [JsonPropertyName("ipv6s")]
        public List<IPv6> IPv6s { get; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; }
    }
}