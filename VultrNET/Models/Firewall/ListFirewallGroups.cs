using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Firewall
{
    public class ListFirewallGroups
    {
        public ListFirewallGroups(List<FirewallGroup> firewallGroups, Meta meta)
        {
            FirewallGroups = firewallGroups;
            Meta = meta;
        }

        [JsonPropertyName("firewall_groups")] public List<FirewallGroup> FirewallGroups { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}