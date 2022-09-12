using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class Instances
    {
        public Instances(List<string> ids)
        {
            Ids = ids;
        }

        [JsonPropertyName("instance_ids")] public List<string> Ids { get; }
    }
}