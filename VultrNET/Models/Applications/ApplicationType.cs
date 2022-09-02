using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Applications
{
    public enum ApplicationType
    {
        [EnumMember(Value = "all")] All,
        [EnumMember(Value = "marketplace")] Marketplace,
        [EnumMember(Value = "one-click")] OneClick
    }
}