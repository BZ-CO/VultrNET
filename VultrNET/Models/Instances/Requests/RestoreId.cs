using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class RestoreId
    {
        public RestoreId(string? backupId = null, string? snapshotId = null)
        {
            if (backupId is null && snapshotId is null)
            {
                throw new ArgumentException(
                    "Provide backupId or snapshotId value");
            }
            BackupId = backupId;
            SnapshotId = snapshotId;
        }

        [JsonPropertyName("backup_id")] public string? BackupId { get; }

        [JsonPropertyName("snapshot_id")] public string? SnapshotId { get; }
    }
}