using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals
{
    public class CreateBareMetalResponse
    {
        public CreateBareMetalResponse(BareMetal bareMetal)
        {
            BareMetal = bareMetal;
        }

        [JsonPropertyName("bare_metal")] public BareMetal BareMetal { get; }
    }
}