using System;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Firewall
{
    public class FirewallGroup
    {
        public FirewallGroup(
            string id,
            string description,
            DateTime dateCreated,
            DateTime dateModified,
            int instanceCount,
            int ruleCount,
            int maxRuleCount)
        {
            Id = id;
            Description = description;
            DateCreated = dateCreated;
            DateModified = dateModified;
            InstanceCount = instanceCount;
            RuleCount = ruleCount;
            MaxRuleCount = maxRuleCount;
        }

        [JsonPropertyName("id")] public string Id { get; }

        [JsonPropertyName("description")] public string Description { get; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; }

        [JsonPropertyName("date_modified")] public DateTime DateModified { get; }

        [JsonPropertyName("instance_count")] public int InstanceCount { get; }

        [JsonPropertyName("rule_count")] public int RuleCount { get; }

        [JsonPropertyName("max_rule_count")] public int MaxRuleCount { get; }
    }
}