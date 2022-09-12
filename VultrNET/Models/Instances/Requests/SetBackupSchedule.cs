using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class SetBackupSchedule
    {
        public SetBackupSchedule(string type, int? hour = default, int? dow = default, int? dom = default)
        {
            Type = type;
            Hour = hour;
            Dow = dow;
            Dom = dom;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("hour")] public int? Hour { get; }

        [JsonPropertyName("dow")] public int? Dow { get; }

        [JsonPropertyName("dom")] public int? Dom { get; }
    }
}