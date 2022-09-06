using System.Text.Json.Serialization;
using VultrNET.Utils;

namespace VultrNET.Models.DNS.Requests
{
    public class CreateDNSRecord
    {
        public CreateDNSRecord(string name, string type, string data, int? ttl = null, int? priority = null)
        {
            Validate.DNSRecordType(type, nameof(type));

            Name = name;
            Type = type;
            Data = data;
            Ttl = ttl;
            Priority = priority;
        }

        [JsonPropertyName("name")] public string Name { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("data")] public string Data { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ttl")]
        public int? Ttl { get; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("priority")]
        public int? Priority { get; }
    }
}