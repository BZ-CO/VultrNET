using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class GetUserData
    {
        public GetUserData(UserData userData)
        {
            UserData = userData;
        }

        [JsonPropertyName("user_data")] public UserData UserData { get; }
    }
}