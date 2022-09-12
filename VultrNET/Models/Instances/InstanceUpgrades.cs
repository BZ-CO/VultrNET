using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class InstanceUpgrades
    {
        public InstanceUpgrades(List<OS> os, List<Application> applications, List<string> plans)
        {
            OS = os;
            Applications = applications;
            Plans = plans;
        }

        [JsonPropertyName("os")] public List<OS> OS { get; }

        [JsonPropertyName("applications")] public List<Application> Applications { get; }

        [JsonPropertyName("plans")] public List<string> Plans { get; }
    }
}