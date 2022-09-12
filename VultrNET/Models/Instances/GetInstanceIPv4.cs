using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class GetInstanceIPv4
    {
        public GetInstanceIPv4(IPv4 ipv4)
        {
            IPv4 = ipv4;
        }

        [JsonPropertyName("ipv4")] public IPv4 IPv4 { get; }
    }
}