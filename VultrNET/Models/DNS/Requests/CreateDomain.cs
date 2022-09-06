using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS.Requests
{
    public class CreateDomain
    {
        public CreateDomain(string domainName, string? ip = null, string? dnssec = null)
        {
            switch (dnssec?.ToLowerInvariant())
            {
                case "enabled":
                case "disabled":
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dnssec), dnssec,
                        $"Invalid DNSSEC {dnssec}, use enabled or disabled");
            }
            
            DomainName = domainName;
            IP = ip;
            DNSSEC = dnssec;
        }

        [JsonPropertyName("domain")] public string DomainName { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ip")]
        public string? IP { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("dns_sec")]
        public string? DNSSEC { get; }
    }
}