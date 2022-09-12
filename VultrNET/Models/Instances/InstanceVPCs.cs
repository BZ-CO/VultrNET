using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class InstanceVPCs
    {
        public InstanceVPCs(string id, string macAddress, string ipAddress)
        {
            Id = id;
            MacAddress = macAddress;
            IpAddress = ipAddress;
        }

        [JsonPropertyName("id")] public string Id { get; set; }

        [JsonPropertyName("mac_address")] public string MacAddress { get; }

        [JsonPropertyName("ip_address")] public string IpAddress { get; set; }
    }
}