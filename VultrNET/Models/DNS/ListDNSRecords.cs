using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.DNS
{
    public class ListDNSRecords
    {
        public ListDNSRecords(List<DNSRecord> records, Meta meta)
        {
            Records = records;
            Meta = meta;
        }

        [JsonPropertyName("records")] public List<DNSRecord> Records { get; set; }

        [JsonPropertyName("meta")] public Meta Meta { get; set; }
    }
}