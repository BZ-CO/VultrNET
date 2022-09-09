using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Firewall
{
    public class ListFirewallRules
    {
        public ListFirewallRules(List<FirewallRule> firewallRules, Meta meta)
        {
            FirewallRules = firewallRules;
            Meta = meta;
        }

        [JsonPropertyName("firewall_rules")]
        public List<FirewallRule> FirewallRules { get; }

        [JsonPropertyName("meta")]
        public Meta Meta { get; }
        
    }
}