using System.Text.Json.Serialization;
using VultrNET.Models.Common;

namespace VultrNET.Models.BareMetals
{
    public class GetBareMetalUserData
    {
        public GetBareMetalUserData(UserData userUserData)
        {
            UserUserData = userUserData;
        }

        [JsonPropertyName("user_data")] public UserData UserUserData { get; }
    }
}