using System.Text.Json.Serialization;

namespace VultrNET.Models.Firewall
{
    public class GetFirewallRule
    {
        public GetFirewallRule(FirewallRule firewallRule)
        {
            FirewallRule = firewallRule;
        }

        [JsonPropertyName("firewall_rule")] public FirewallRule FirewallRule { get; }
    }
}