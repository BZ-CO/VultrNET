using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals
{
    public class GetBareMetal
    {
        public GetBareMetal(BareMetal bareMetal)
        {
            BareMetal = bareMetal;
        }

        [JsonPropertyName("bare_metals")] public BareMetal BareMetal { get; }
    }
}