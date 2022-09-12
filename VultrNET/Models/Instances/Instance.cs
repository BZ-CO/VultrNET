using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.Instances
{
    public class Instance
    {
        public Instance(
            string id,
            string os,
            int ram,
            int disk,
            string mainIP,
            int virtualCpuCount,
            string region,
            string plan,
            DateTime dateCreated,
            string status,
            int allowedBandwidth,
            string netmaskV4,
            string gatewayV4,
            string powerStatus,
            string serverStatus,
            string v6Network,
            string v6MainIP,
            int v6NetworkSize,
            string? label,
            string? internalIP,
            string kvm,
            string hostname,
            int osId,
            int appId,
            string imageId,
            string firewallGroupId,
            List<string> features,
            string defaultPassword,
            List<string> tags)
        {
            Id = id;
            OS = os;
            RAM = ram;
            Disk = disk;
            MainIP = mainIP;
            VirtualCpuCount = virtualCpuCount;
            Region = region;
            Plan = plan;
            DateCreated = dateCreated;
            Status = status;
            AllowedBandwidth = allowedBandwidth;
            NetmaskV4 = netmaskV4;
            GatewayV4 = gatewayV4;
            PowerStatus = powerStatus;
            ServerStatus = serverStatus;
            V6Network = v6Network;
            V6MainIP = v6MainIP;
            V6NetworkSize = v6NetworkSize;
            Label = label;
            InternalIP = internalIP;
            Kvm = kvm;
            Hostname = hostname;
            OSId = osId;
            AppId = appId;
            ImageId = imageId;
            FirewallGroupId = firewallGroupId;
            Features = features;
            DefaultPassword = defaultPassword;
            Tags = tags;
        }

        [JsonPropertyName("id")] public string Id { get; }

        [JsonPropertyName("os")] public string OS { get; }

        [JsonPropertyName("ram")] public int RAM { get; }

        [JsonPropertyName("disk")] public int Disk { get; }

        [JsonPropertyName("main_ip")] public string MainIP { get; }

        [JsonPropertyName("vcpu_count")] public int VirtualCpuCount { get; }

        [JsonPropertyName("region")] public string Region { get; }

        [JsonPropertyName("plan")] public string Plan { get; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; }

        [JsonPropertyName("status")] public string Status { get; }

        [JsonPropertyName("allowed_bandwidth")]
        public int AllowedBandwidth { get; }

        [JsonPropertyName("netmask_v4")] public string NetmaskV4 { get; }

        [JsonPropertyName("gateway_v4")] public string GatewayV4 { get; }

        [JsonPropertyName("power_status")] public string PowerStatus { get; }

        [JsonPropertyName("server_status")] public string ServerStatus { get; }

        [JsonPropertyName("v6_network")] public string V6Network { get; }

        [JsonPropertyName("v6_main_ip")] public string V6MainIP { get; }

        [JsonPropertyName("v6_network_size")] public int V6NetworkSize { get; }

        [JsonPropertyName("label")] public string? Label { get; }

        [JsonPropertyName("internal_ip")] public string? InternalIP { get; }

        [JsonPropertyName("kvm")] public string Kvm { get; }

        [JsonPropertyName("hostname")] public string Hostname { get; }

        [JsonPropertyName("os_id")] public int OSId { get; }

        [JsonPropertyName("app_id")] public int AppId { get; }

        [JsonPropertyName("image_id")] public string ImageId { get; }

        [JsonPropertyName("firewall_group_id")]
        public string FirewallGroupId { get; }

        [JsonPropertyName("features")] public List<string> Features { get; }

        [JsonPropertyName("default_password")] public string DefaultPassword { get; set; }

        [JsonPropertyName("tags")] public List<string> Tags { get; }
    }
}