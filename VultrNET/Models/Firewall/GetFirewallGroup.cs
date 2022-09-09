using System.Text.Json.Serialization;

namespace VultrNET.Models.Firewall
{
    public class GetFirewallGroup
    {
        public GetFirewallGroup(FirewallGroup firewallGroup)
        {
            FirewallGroup = firewallGroup;
        }

        [JsonPropertyName("firewall_group")] public FirewallGroup FirewallGroup { get; }
    }
}