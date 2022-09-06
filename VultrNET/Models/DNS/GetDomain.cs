using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS
{
    public class GetDomain
    {
        public GetDomain(Domain domain)
        {
            Domain = domain;
        }

        [JsonPropertyName("domain")] public Domain Domain { get; }
    }
}