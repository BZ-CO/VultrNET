using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class Meta
    {
        public Meta(int total, Links links)
        {
            Total = total;
            Links = links;
        }

        [JsonPropertyName("total")]
        public int Total { get; }

        [JsonPropertyName("links")]
        public Links Links { get; }
    }
}