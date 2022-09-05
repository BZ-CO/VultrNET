using System.Text.Json.Serialization;

namespace VultrNET.Models.BlockStorage
{
    public class GetBlockStorage
    {
        public GetBlockStorage(Block block)
        {
            Block = block;
        }

        [JsonPropertyName("block")] public Block Block { get; }
    }
}