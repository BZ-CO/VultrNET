using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Backups
{
    public class ListBackups
    {
        public ListBackups(List<Backup> backups, Meta meta)
        {
            Backups = backups;
            Meta = meta;
        }

        [JsonPropertyName("backups")] public List<Backup> Backups { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}