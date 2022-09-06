using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS
{
    public class DNSRecord
    {
        public DNSRecord(string name, string type, string data, int ttl, int priority)
        {
            Name = name;
            Type = type;
            Data = data;
            Ttl = ttl;
            Priority = priority;
        }

        [JsonPropertyName("name")] public string Name { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("data")] public string Data { get; }

        [JsonPropertyName("ttl")] public int Ttl { get; }

        [JsonPropertyName("priority")] public int Priority { get; }
    }
}