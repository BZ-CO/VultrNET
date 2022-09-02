using System.Collections.Generic;
using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.Applications
{
    public class ListApplications
    {
        public ListApplications(List<Application> applications, Meta meta)
        {
            Applications = applications;
            Meta = meta;
        }

        [JsonPropertyName("applications")] public List<Application> Applications { get; }

        [JsonPropertyName("meta")] public Meta Meta { get; }
    }
}