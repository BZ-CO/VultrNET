using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class GetAvailableInstanceUpgrades
    {
        public GetAvailableInstanceUpgrades(InstanceUpgrades upgrades)
        {
            Upgrades = upgrades;
        }

        [JsonPropertyName("upgrades")] public InstanceUpgrades Upgrades { get; }
    }
}