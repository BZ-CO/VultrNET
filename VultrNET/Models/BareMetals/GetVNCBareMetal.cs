using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class GetVNCBareMetal
    {
        public GetVNCBareMetal(Url userUserData)
        {
            UserUserData = userUserData;
        }

        [JsonPropertyName("vnc")] public Url UserUserData { get; }
    }
}