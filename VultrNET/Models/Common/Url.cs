using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class Url
    {
        public Url(string value)
        {
            Value = value;
        }

        [JsonPropertyName("url")] public string Value { get; }
    }
}