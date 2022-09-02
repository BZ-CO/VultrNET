using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class IPv6
    {
        public IPv6(string ip, string network, int networkSize, string type)
        {
            Ip = ip;
            Network = network;
            NetworkSize = networkSize;
            Type = type;
        }

        [JsonPropertyName("ip")] public string Ip { get; }

        [JsonPropertyName("network")] public string Network { get; }

        [JsonPropertyName("network_size")] public int NetworkSize { get; }

        [JsonPropertyName("type")] public string Type { get; }
    }
}