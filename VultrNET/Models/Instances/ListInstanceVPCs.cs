using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Instances
{
    public class ListInstanceVPCs
    {
        public ListInstanceVPCs(List<InstanceVPCs> virtualPrivateClouds, Meta meta)
        {
            VirtualPrivateClouds = virtualPrivateClouds;
            Meta = meta;
        }

        [JsonPropertyName("vpcs")] public List<InstanceVPCs> VirtualPrivateClouds { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}