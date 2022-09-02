using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class UserData
    {
        public UserData(string data)
        {
            Data = data;
        }

        [JsonPropertyName("data")] public string Data { get; }
    }
}