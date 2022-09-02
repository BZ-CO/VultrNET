using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VultrNET.Models.BareMetals
{
    public class BareMetal
    {
        public BareMetal(string id, string os, string ram, string disk, string mainIp, int cpuCount, string region,
            string defaultPassword, DateTime dateCreated, string status, string netmaskV4, string gatewayV4,
            string plan, string v6Network, string v6MainIp, int v6NetworkSize, string label, long macAddress, int osId,
            int appId, string imageId, List<string> features, List<string> tags)
        {
            Id = id;
            Os = os;
            Ram = ram;
            Disk = disk;
            MainIp = mainIp;
            CpuCount = cpuCount;
            Region = region;
            DefaultPassword = defaultPassword;
            DateCreated = dateCreated;
            Status = status;
            NetmaskV4 = netmaskV4;
            GatewayV4 = gatewayV4;
            Plan = plan;
            V6Network = v6Network;
            V6MainIp = v6MainIp;
            V6NetworkSize = v6NetworkSize;
            Label = label;
            MacAddress = macAddress;
            OsId = osId;
            AppId = appId;
            ImageId = imageId;
            Features = features;
            Tags = tags;
        }

        [JsonPropertyName("id")] public string Id { get; }

        [JsonPropertyName("os")] public string Os { get; }

        [JsonPropertyName("ram")] public string Ram { get; }

        [JsonPropertyName("disk")] public string Disk { get; }

        [JsonPropertyName("main_ip")] public string MainIp { get; }

        [JsonPropertyName("cpu_count")] public int CpuCount { get; }

        [JsonPropertyName("region")] public string Region { get; }

        [JsonPropertyName("default_password")] public string DefaultPassword { get; }

        [JsonPropertyName("date_created")] public DateTime DateCreated { get; }

        [JsonPropertyName("status")] public string Status { get; }

        [JsonPropertyName("netmask_v4")] public string NetmaskV4 { get; }

        [JsonPropertyName("gateway_v4")] public string GatewayV4 { get; }

        [JsonPropertyName("plan")] public string Plan { get; }

        [JsonPropertyName("v6_network")] public string V6Network { get; }

        [JsonPropertyName("v6_main_ip")] public string V6MainIp { get; }

        [JsonPropertyName("v6_network_size")] public int V6NetworkSize { get; }

        [JsonPropertyName("label")] public string Label { get; }

        [JsonPropertyName("mac_address")] public long MacAddress { get; }

        [JsonPropertyName("os_id")] public int OsId { get; }

        [JsonPropertyName("app_id")] public int AppId { get; }

        [JsonPropertyName("image_id")] public string ImageId { get; }

        [JsonPropertyName("features")] public List<string> Features { get; }

        [JsonPropertyName("tags")] public List<string> Tags { get; }
    }
}