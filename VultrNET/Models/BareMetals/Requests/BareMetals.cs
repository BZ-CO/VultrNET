using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals.Requests
{
    public class BareMetals
    {
        public BareMetals(List<string> ids)
        {
            Ids = ids;
        }

        [JsonPropertyName("baremetal_ids")] public List<string> Ids { get; }
    }
}