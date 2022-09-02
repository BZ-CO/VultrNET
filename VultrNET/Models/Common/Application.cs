using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class Application
    {
        public Application(
            int id,
            string name,
            string shortName,
            string deployName,
            string type,
            string vendor,
            string imageId)
        {
            Id = id;
            Name = name;
            ShortName = shortName;
            DeployName = deployName;
            Type = type;
            Vendor = vendor;
            ImageId = imageId;
        }

        [JsonPropertyName("id")] public int Id { get; }

        [JsonPropertyName("name")] public string Name { get; }

        [JsonPropertyName("short_name")] public string ShortName { get; }

        [JsonPropertyName("deploy_name")] public string DeployName { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("vendor")] public string Vendor { get; }

        [JsonPropertyName("image_id")] public string ImageId { get; }
    }
}