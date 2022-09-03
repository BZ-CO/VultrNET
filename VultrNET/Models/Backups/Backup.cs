using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Backups
{
    public class Backup
    {
        public Backup(
            string id,
            DateTime dateCreated,
            string description,
            long size,
            string status)
        {
            Id = id;
            DateCreated = dateCreated;
            Description = description;
            Size = size;
            Status = status;
        }

        [JsonPropertyName("id")] public string Id { get; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; }

        [JsonPropertyName("description")] public string Description { get; }

        [JsonPropertyName("size")] public long Size { get; }

        [JsonPropertyName("status")] public string Status { get; }
    }
}