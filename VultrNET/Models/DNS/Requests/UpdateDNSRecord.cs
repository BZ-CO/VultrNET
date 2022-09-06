using System.Text.Json.Serialization;
using VultrNET.Utils;

namespace VultrNET.Models.DNS.Requests
{
    public class UpdateDNSRecord
    {
        public UpdateDNSRecord(string? name, string? type, string? data, int? ttl, int? priority)
        {
            if (type != null)
            {
                Validate.DNSRecordType(type, nameof(type));
            }

            Name = name;
            Type = type;
            Data = data;
            Ttl = ttl;
            Priority = priority;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string? Name { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("type")]
        public string? Type { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("data")]
        public string? Data { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ttl")]
        public int? Ttl { get; }


        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("priority")]
        public int? Priority { get; }
    }
}