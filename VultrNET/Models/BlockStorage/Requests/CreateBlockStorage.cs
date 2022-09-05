using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BlockStorage.Requests
{
    public class CreateBlockStorage
    {
        public CreateBlockStorage(string region, int sizeGb, string blockType, string? label = null)
        {
            switch (blockType.ToLowerInvariant())
            {
                case "high_perf":
                case "storage_opt":
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(blockType), blockType,
                        $"Invalid block type {blockType}, use high_perf or storage_opt");
            }

            Region = region;
            SizeGb = sizeGb;
            BlockType = blockType;
            Label = label;
        }

        [JsonPropertyName("region")] public string Region { get; }

        [JsonPropertyName("size_gb")] public int SizeGb { get; }

        [JsonPropertyName("block_type")] public string BlockType { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public string? Label { get; }
    }
}