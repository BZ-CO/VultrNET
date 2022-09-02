using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class GetVNCBareMetal
    {
        [JsonPropertyName("vnc")] public Url UserUserData { get; }
    }
}