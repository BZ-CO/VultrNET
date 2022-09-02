using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals
{
    public class GetAvailableBareMetalUpgrades
    {
        public GetAvailableBareMetalUpgrades(BareMetalUpgrades upgrades)
        {
            Upgrades = upgrades;
        }

        [JsonPropertyName("upgrades")] public BareMetalUpgrades Upgrades { get; }
    }
}