using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class Neighbors
    {
        public Neighbors(List<string> ids)
        {
            Ids = ids;
        }

        [JsonPropertyName("neighbors")] public List<string> Ids { get; }
    }
}