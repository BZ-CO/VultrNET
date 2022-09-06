using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS
{
    public class GetDNSRecord
    {
        public GetDNSRecord(DNSRecord record)
        {
            Record = record;
        }

        [JsonPropertyName("record")] public DNSRecord Record { get; }
    }
}