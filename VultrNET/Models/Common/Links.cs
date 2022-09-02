using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class Links
    {
        public Links(string next, string prev)
        {
            Next = next;
            Prev = prev;
        }

        [JsonPropertyName("next")] public string Next { get; }

        [JsonPropertyName("prev")] public string Prev { get; }
    }
}