using System.Text.Json.Serialization;

namespace VultrNET.Models.Common
{
    public class OS
    {
        public OS(int id, string name, string arch, string family)
        {
            Id = id;
            Name = name;
            Arch = arch;
            Family = family;
        }

        [JsonPropertyName("id")] public int Id { get; }

        [JsonPropertyName("name")] public string Name { get; }

        [JsonPropertyName("arch")] public string Arch { get; }

        [JsonPropertyName("family")] public string Family { get; }
    }
}