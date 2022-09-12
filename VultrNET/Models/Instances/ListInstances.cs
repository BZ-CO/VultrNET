using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class ListInstances
    {
        public ListInstances(List<Instance> instances, Meta meta)
        {
            Instances = instances;
            Meta = meta;
        }

        [JsonPropertyName("instances")] public List<Instance> Instances { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}