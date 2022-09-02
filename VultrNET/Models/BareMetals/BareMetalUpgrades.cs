using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class BareMetalUpgrades
    {
        public BareMetalUpgrades(List<OS> os, List<Application> applications)
        {
            Os = os;
            Applications = applications;
        }

        [JsonPropertyName("os")] public List<OS> Os { get; }

        [JsonPropertyName("applications")] public List<Application> Applications { get; }
    }
}