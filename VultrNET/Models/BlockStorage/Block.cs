using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BlockStorage
{
    public class Block
    {
        public Block(
            string id,
            DateTime dateCreated,
            decimal cost,
            string status,
            int sizeGb,
            string region,
            string attachedToInstance,
            string label,
            string mountId,
            string? blockType)
        {
            Id = id;
            DateCreated = dateCreated;
            Cost = cost;
            Status = status;
            SizeGb = sizeGb;
            Region = region;
            AttachedToInstance = attachedToInstance;
            Label = label;
            MountId = mountId;
            BlockType = blockType;
        }

        [JsonPropertyName("id")] public string Id { get; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; }

        [JsonPropertyName("cost")] public decimal Cost { get; }

        [JsonPropertyName("status")] public string Status { get; }

        [JsonPropertyName("size_gb")] public int SizeGb { get; }

        [JsonPropertyName("region")] public string Region { get; }

        [JsonPropertyName("attached_to_instance")] public string AttachedToInstance { get; }

        [JsonPropertyName("label")] public string Label { get; }

        [JsonPropertyName("mount_id")] public string MountId { get; }

        [JsonPropertyName("block_type")] public string? BlockType { get; }
    }
}