using System.Text.Json.Serialization;

namespace VultrNET.Models.Account
{
    public class GetAccountInfo
    {
        public GetAccountInfo(Account info)
        {
            Info = info;
        }

        [JsonPropertyName("account")] public Account Info { get; }
    }
}