using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class ListIPv6Reverse
    {
        public ListIPv6Reverse(List<ReverseEntry> reverseIPv6S)
        {
            ReverseIPv6s = reverseIPv6S;
        }

        [JsonPropertyName("reverse_ipv6s")] public List<ReverseEntry> ReverseIPv6s { get; }
    }
}