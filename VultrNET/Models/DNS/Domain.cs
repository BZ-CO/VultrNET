using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS
{
    public class Domain
    {
        public Domain(string domainName, DateTime dateCreated, string dnssec)
        {
            DomainName = domainName;
            DateCreated = dateCreated;
            DNSSEC = dnssec;
        }

        [JsonPropertyName("domain")] public string DomainName { get; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; }

        [JsonPropertyName("dns_sec")] public string DNSSEC { get; }
    }
}