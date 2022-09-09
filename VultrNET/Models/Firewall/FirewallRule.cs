using System.Text.Json.Serialization;

namespace VultrNET.Models.Firewall
{
    public class FirewallRule
    {
        public FirewallRule(
            int id,
            string type,
            string ipType,
            string action,
            string protocol,
            string port,
            string subnet,
            int subnetSize,
            string? source,
            string? notes)
        {
            Id = id;
            Type = type;
            IPType = ipType;
            Action = action;
            Protocol = protocol;
            Port = port;
            Subnet = subnet;
            SubnetSize = subnetSize;
            Source = source;
            Notes = notes;
        }

        [JsonPropertyName("id")] public int Id { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("ip_type")] public string IPType { get; }

        [JsonPropertyName("action")] public string Action { get; }

        [JsonPropertyName("protocol")] public string Protocol { get; }

        [JsonPropertyName("port")] public string Port { get; }

        [JsonPropertyName("subnet")] public string Subnet { get; }

        [JsonPropertyName("subnet_size")] public int SubnetSize { get; }

        [JsonPropertyName("source")] public string? Source { get; }

        [JsonPropertyName("notes")] public string? Notes { get; }
    }
}