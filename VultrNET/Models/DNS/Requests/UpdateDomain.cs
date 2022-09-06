using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS.Requests
{
    public class UpdateDomain
    {
        public UpdateDomain(string dnssec)
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
            DNSSEC = dnssec;
        }

        [JsonPropertyName("dns_sec")] public string DNSSEC { get; }
    }
}