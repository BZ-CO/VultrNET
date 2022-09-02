using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals.Requests
{
    public class CreateBareMetal
    {
        public CreateBareMetal(
            string region, string plan, string? scriptId = null, bool? enableIPv6 = null,
            List<string>? sshKeyId = null, string? userData = null, string? label = null, bool? activationEmail = null,
            string? hostname = null,
            string? reservedIPv4 = null, int? osId = null, string? snapshotId = null, int? appId = null,
            string? imageId = null, bool? persistentPXE = null,
            List<string>? tags = null)
        {
            Region = region;
            Plan = plan;
            ScriptId = scriptId;
            EnableIPv6 = enableIPv6;
            SSHKeyId = sshKeyId;
            UserData = userData;
            Label = label;
            ActivationEmail = activationEmail;
            Hostname = hostname;
            ReservedIPv4 = reservedIPv4;
            OSId = osId;
            SnapshotId = snapshotId;
            AppId = appId;
            ImageId = imageId;
            PersistentPXE = persistentPXE;
            Tags = tags;
        }

        [JsonPropertyName("region")] public string Region { get; }
        [JsonPropertyName("plan")] public string Plan { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("script_id")]
        public string? ScriptId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("enable_ipv6")]
        public bool? EnableIPv6 { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("sshkey_id")]
        public List<string>? SSHKeyId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("user_data")]
        public string? UserData { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("label")]
        public string? Label { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("activation_email")]
        public bool? ActivationEmail { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("hostname")]
        public string? Hostname { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("reserver_ipv4")]
        public string? ReservedIPv4 { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("os_id")]
        public int? OSId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("app_id")]
        public int? AppId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("image_id")]
        public string? ImageId { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("persistent_pxe")]
        public bool? PersistentPXE { get; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("tags")]
        public List<string>? Tags { get; }
    }
}