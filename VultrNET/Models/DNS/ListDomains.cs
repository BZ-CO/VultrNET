using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.DNS
{
    public class ListDomains
    {
        public ListDomains(List<Domain> domains, Meta meta)
        {
            Domains = domains;
            Meta = meta;
        }

        [JsonPropertyName("domains")] public List<Domain> Domains { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}