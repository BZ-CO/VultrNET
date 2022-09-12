using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class ReverseEntry
    {
        public ReverseEntry(string ip, string reverse)
        {
            IP = ip;
            Reverse = reverse;
        }

        [JsonPropertyName("ip")] public string IP { get; }

        [JsonPropertyName("reverse")] public string Reverse { get; }
    }
}