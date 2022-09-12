using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class BackupSchedule
    {
        public BackupSchedule(bool enabled, string type, DateTime nextScheduledTimeUtc, int hour, int dow, int dom)
        {
            Enabled = enabled;
            Type = type;
            NextScheduledTimeUtc = nextScheduledTimeUtc;
            Hour = hour;
            Dow = dow;
            Dom = dom;
        }

        [JsonPropertyName("enabled")] public bool Enabled { get; }

        [JsonPropertyName("type")] public string Type { get; }

        [JsonPropertyName("next_scheduled_time_utc")]
        public DateTime NextScheduledTimeUtc { get; }

        [JsonPropertyName("hour")] public int Hour { get; }

        [JsonPropertyName("dow")] public int Dow { get; }

        [JsonPropertyName("dom")] public int Dom { get; }
    }
}