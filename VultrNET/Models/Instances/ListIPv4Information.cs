using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class ListIPv4Information
    {
        public ListIPv4Information(List<IPv4> ipv4s, Meta meta)
        {
            IPv4s = ipv4s;
            Meta = meta;
        }

        [JsonPropertyName("ipv4s")]
        public List<IPv4> IPv4s { get; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; }
    }
}