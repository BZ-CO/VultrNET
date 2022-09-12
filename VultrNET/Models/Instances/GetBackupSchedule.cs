using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class GetBackupSchedule
    {
        public GetBackupSchedule(BackupSchedule backupSchedule)
        {
            BackupSchedule = backupSchedule;
        }

        [JsonPropertyName("backup_schedule")]
        public BackupSchedule BackupSchedule { get; }
    }
}