using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BlockStorage.Requests
{
    public class UpdateBlockStorage
    {
        public UpdateBlockStorage(string? label = null, int? sizeInGB = null)
        {
            Label = label;
            SizeInGB = sizeInGB;
            if (!sizeInGB.HasValue && (sizeInGB < 10 || sizeInGB > 10000))
                throw new ArgumentOutOfRangeException(nameof(sizeInGB), sizeInGB,
                    $"Invalid size {sizeInGB} GB, may range between 10 and 10000");
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public string? Label { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public int? SizeInGB { get; }
    }
}