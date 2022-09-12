using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class UpdateInstance
    {
        public UpdateInstance(
            int? appId = null,
            string? imageId = null,
            string? backups = null,
            string? firewallGroupId = null,
            bool? enableIPv6 = null,
            int? osId = null,
            string? userData = null,
            string? plan = null,
            bool? dDoSProtection = null,
            List<string>? attachVPC = null,
            List<string>? detachVPC = null,
            bool? enableVPC = null,
            string? label = null,
            List<string>? tags = null)
        {
            AppId = appId;
            ImageId = imageId;
            Backups = backups;
            FirewallGroupId = firewallGroupId;
            EnableIPv6 = enableIPv6;
            OsId = osId;
            UserData = userData;
            Plan = plan;
            DDoSProtection = dDoSProtection;
            AttachVPC = attachVPC;
            DetachVPC = detachVPC;
            EnableVPC = enableVPC;
            Label = label;
            Tags = tags;
        }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("app_id")]
        public int? AppId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("image_id")]
        public string? ImageId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("backups")]
        public string? Backups { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("firewall_group_id")]
        public string? FirewallGroupId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enable_ipv6")]
        public bool? EnableIPv6 { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("os_id")]
        public int? OsId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("user_data")]
        public string? UserData { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("plan")]
        public string? Plan { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ddos_protection")]
        public bool? DDoSProtection { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attach_vpc")]
        public List<string>? AttachVPC { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("detach_vpc")]
        public List<string>? DetachVPC { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enable_vpc")]
        public bool? EnableVPC { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public string? Label { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; }
    }
}