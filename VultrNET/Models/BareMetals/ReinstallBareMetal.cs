using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals
{
    public class ReinstallBareMetal
    {
        [JsonPropertyName("bare_metal")] public BareMetal BareMetal { get; }
    }
}