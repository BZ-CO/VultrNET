using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances.Requests
{
    public class CreateInstance
    {
        public CreateInstance(
            string region,
            string plan,
            int? osId = default,
            string? ipxeChainURL = null,
            int? isoId = default,
            int? scriptId = default,
            int? snapshotId = default,
            bool? enableIPv6 = default,
            List<string>? attachVPC = null,
            string? label = null,
            List<string>? sshKeyId = null,
            string? backups = null,
            int? appId = default,
            string? imageId = null,
            string? userData = null,
            bool? dDoSProtection = default,
            bool? activationEmail = default,
            string? hostname = null,
            string? firewallGroupId = null,
            string? reservedIPv4 = null,
            bool? enableVPC = default,
            List<string>? tags = null)
        {
            if (osId is null && isoId is null && snapshotId is null && appId is null && imageId is null)
            {
                throw new ArgumentException(
                    "Choose one of the following to deploy the instance: osId | isoId | snapshotId | appId | imageId");
            }

            Region = region;
            Plan = plan;
            OsId = osId;
            IPXEChainURL = ipxeChainURL;
            ISOId = isoId;
            ScriptId = scriptId;
            SnapshotId = snapshotId;
            EnableIPv6 = enableIPv6;
            AttachVPC = attachVPC;
            Label = label;
            SSHKeyId = sshKeyId;
            Backups = backups;
            AppId = appId;
            ImageId = imageId;
            UserData = userData;
            DDoSProtection = dDoSProtection;
            ActivationEmail = activationEmail;
            Hostname = hostname;
            FirewallGroupId = firewallGroupId;
            ReservedIPv4 = reservedIPv4;
            EnableVPC = enableVPC;
            Tags = tags;
        }

        [JsonPropertyName("region")] public string Region { get; }

        [JsonPropertyName("plan")] public string Plan { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("os_id")]
        public int? OsId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ipxe_chain_url")]
        public string? IPXEChainURL { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("iso_id")]
        public int? ISOId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("script_id")]
        public int? ScriptId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("snapshot_id")]
        public int? SnapshotId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enable_ipv6")]
        public bool? EnableIPv6 { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attach_vpc")]
        public List<string>? AttachVPC { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public string? Label { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sshkey_id")]
        public List<string>? SSHKeyId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("backups")]
        public string? Backups { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("app_id")]
        public int? AppId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("image_id")]
        public string? ImageId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("user_data")]
        public string? UserData { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("ddos_protection")]
        public bool? DDoSProtection { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("activation_email")]
        public bool? ActivationEmail { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hostname")]
        public string? Hostname { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("firewall_group_id")]
        public string? FirewallGroupId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("reserved_ipv4")]
        public string? ReservedIPv4 { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enable_vpc")]
        public bool? EnableVPC { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; }
    }
}