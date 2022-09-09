using System.Text.Json.Serialization;

namespace VultrNET.Models.Firewall.Requests
{
    public class CreateFirewallRule
    {
        public CreateFirewallRule(
            string ipType,
            string protocol,
            string port,
            string subnet,
            int subnetSize,
            string? source = null,
            string? notes = null)
        {
            IPType = ipType;
            Protocol = protocol;
            Port = port;
            Subnet = subnet;
            SubnetSize = subnetSize;
            Source = source;
            Notes = notes;
        }

        [JsonPropertyName("ip_type")] public string IPType { get; }

        [JsonPropertyName("protocol")] public string Protocol { get; }

        [JsonPropertyName("port")] public string Port { get; }

        [JsonPropertyName("subnet")] public string Subnet { get; }

        [JsonPropertyName("subnet_size")] public int SubnetSize { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("source")]
        public string? Source { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("notes")]
        public string? Notes { get; }
    }
}