using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals
{
    public class ReinstallBareMetal
    {
        public ReinstallBareMetal(BareMetal bareMetal)
        {
            BareMetal = bareMetal;
        }

        [JsonPropertyName("bare_metal")] public BareMetal BareMetal { get; }
    }
}