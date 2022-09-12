using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class GetInstance
    {
        public GetInstance(Instance instance)
        {
            Instance = instance;
        }

        [JsonPropertyName("instance")] public Instance Instance { get; }
    }
}