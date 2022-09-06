using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS
{
    public class GetSOAInformation
    {
        public GetSOAInformation(StartOfAuthority soa)
        {
            SOA = soa;
        }

        [JsonPropertyName("dns_soa")]
        public StartOfAuthority SOA { get; }
    }
}