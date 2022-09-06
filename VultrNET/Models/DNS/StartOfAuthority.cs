using System.Text.Json.Serialization;

namespace VultrNET.Models.DNS
{
    public class StartOfAuthority
    {
        public StartOfAuthority(string nsPrimary, string email)
        {
            NSPrimary = nsPrimary;
            Email = email;
        }

        [JsonPropertyName("nsprimary")] public string NSPrimary { get; }

        [JsonPropertyName("email")] public string Email { get; }
    }
}