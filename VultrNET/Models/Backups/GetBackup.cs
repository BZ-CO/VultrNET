using System.Text.Json.Serialization;

namespace VultrNET.Models.Backups
{
    public class GetBackup
    {
        public GetBackup(Backup backup)
        {
            Backup = backup;
        }

        [JsonPropertyName("backup")] public Backup Backup { get; }
    }
}