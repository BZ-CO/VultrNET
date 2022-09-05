using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BlockStorage
{
    public class ListBlockStorages
    {
        public ListBlockStorages(List<Block> blocks, Meta meta)
        {
            Blocks = blocks;
            Meta = meta;
        }

        [JsonPropertyName("blocks")] public List<Block> Blocks { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}