using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class IPv4
    {
        public IPv4(string ip, string netmask, string gateway, string type, string reverse)
        {
            Ip = ip;
            Netmask = netmask;
            Gateway = gateway;
            Type = type;
            Reverse = reverse;
        }

        [JsonPropertyName("ip")] public string Ip { get; }

        [JsonPropertyName("netmask")] public string Netmask { get; }

        [JsonPropertyName("gateway")] public string Gateway { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("reverse")] public string Reverse { get; }
    }
}