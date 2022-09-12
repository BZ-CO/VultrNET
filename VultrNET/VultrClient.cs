using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using VultrNET.Models.Account;
using VultrNET.Models.Applications;
using VultrNET.Models.Backups;
using VultrNET.Models.BareMetals;
using VultrNET.Models.BareMetals.Requests;
using VultrNET.Models.Billing;
using VultrNET.Models.BlockStorage;
using VultrNET.Models.BlockStorage.Requests;
using VultrNET.Models.Common;
using VultrNET.Models.DNS;
using VultrNET.Models.DNS.Requests;
using VultrNET.Models.Firewall;
using VultrNET.Models.Firewall.Requests;
using VultrNET.Models.Instances;
using VultrNET.Models.Instances.Requests;
using VultrNET.Utils;

namespace VultrNET
{
    public class VultrClient
    {
        private const string BaseUrl = "https://api.vultr.com/v2";
        private const string AccountEndpoint = "account";
        private const string ApplicationsEndoint = "applications";
        private const string BackupsEndpoint = "backups";
        private const string BareMetalsEndpoint = "bare-metals";
        private const string BillingEndpoint = "billing";
        private const string BlockStorageEndpoint = "blocks";
        private const string DNSEndpoint = "domains";
        private const string FirewallEndpoint = "firewalls";
        private const string InstancesEndpoint = "instances";
        private readonly string _apiKey;

        public VultrClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<GetAccountInfo> GetAccountInfoAsync() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(AccountEndpoint)
                    .GetAsync<GetAccountInfo>(_apiKey));

        public async Task<ListApplications> ListApplications(
            string applicationType,
            int page = 150,
            string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(ApplicationsEndoint)
                    .SetQueryParamIfAvailable("type", applicationType.ToLowerInvariant())
                    .SetPagination(page, cursor)
                    .GetAsync<ListApplications>(_apiKey));

        public async Task<ListBackups> ListBackups(string id = "", int page = 100, string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BackupsEndpoint)
                    .SetQueryParamIfAvailable("instance_id", id)
                    .SetPagination(page, cursor)
                    .GetAsync<ListBackups>(_apiKey));

        public async Task<GetBackup> GetBackup(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BackupsEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetBackup>(_apiKey));

        public async Task<ListBareMetalInstances> ListBareMetalInstances(int page = 100, string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .SetPagination(page, cursor)
                    .GetAsync<ListBareMetalInstances>(_apiKey));

        public async Task<CreateBareMetalResponse> CreateBareMetalInstance(CreateBareMetal instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .PostAsync<CreateBareMetalResponse>(_apiKey, instance));

        public async Task<GetBareMetal> GetBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetBareMetal>(_apiKey));

        public async Task<IFlurlResponse> UpdateBareMetal(string id, UpdateBareMetal instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .PatchAsync(instance, _apiKey));

        public async Task<IFlurlResponse> DeleteBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .DeleteAsync(_apiKey));

        public async Task<BareMetalIPv4Addresses> GetBareMetalIPv4Addresses(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv4")
                    .GetAsync<BareMetalIPv4Addresses>(_apiKey));

        public async Task<BareMetalIPv6Addresses> GetBareMetalIPv6Addresses(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv6")
                    .GetAsync<BareMetalIPv6Addresses>(_apiKey));

        public async Task<IFlurlResponse> StartBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("start")
                    .PostAsync(_apiKey));

        public async Task<IFlurlResponse> RebootBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("reboot")
                    .PostAsync(_apiKey));

        public async Task<ReinstallBareMetal> ReinstallBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("reinstall")
                    .PostAsync<ReinstallBareMetal>(_apiKey));

        public async Task<IFlurlResponse> HaltBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("halt")
                    .PostAsync(_apiKey));

        public async Task<BandwidthHistory> GetBareMetalBandwidth(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("bandwidth")
                    .GetAsync<BandwidthHistory>(_apiKey));

        public async Task<IFlurlResponse> HaltBareMetals(BareMetals ids) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment("halt")
                    .PostAsync(_apiKey));

        public async Task<IFlurlResponse> RebootMetals(BareMetals ids) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment("reboot")
                    .PostAsync(_apiKey));

        public async Task<IFlurlResponse> StartBareMetals(BareMetals ids) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment("start")
                    .PostAsync(_apiKey));

        public async Task<GetUserData> GetBareMetalUserData(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("user-data")
                    .GetAsync<GetUserData>(_apiKey));

        public async Task<GetAvailableBareMetalUpgrades>
            GetAvailableUpgradesForBareMetal(string id, string type = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("upgrades")
                    .SetQueryParamIfAvailable("type", type.ToLowerInvariant())
                    .GetAsync<GetAvailableBareMetalUpgrades>(_apiKey));

        public async Task<GetVNCBareMetal> GetVNCForBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("vnc")
                    .GetAsync<GetVNCBareMetal>(_apiKey));

        public async Task<ListBillingHistory> ListBillingHistory() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BillingEndpoint)
                    .AppendPathSegment("history")
                    .GetAsync<ListBillingHistory>(_apiKey));

        public async Task<ListInvoices> ListInvoices() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BillingEndpoint)
                    .AppendPathSegment("invoices")
                    .GetAsync<ListInvoices>(_apiKey));

        public async Task<GetInvoice> GetInvoice(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BillingEndpoint)
                    .AppendPathSegment("invoices")
                    .AppendPathSegment(id)
                    .GetAsync<GetInvoice>(_apiKey));

        public async Task<GetInvoiceItems> GetInvoiceItems(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BillingEndpoint)
                    .AppendPathSegment("invoices")
                    .AppendPathSegment(id)
                    .AppendPathSegment("items")
                    .GetAsync<GetInvoiceItems>(_apiKey));

        public async Task<ListBlockStorages> ListBlockStorages() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .GetAsync<ListBlockStorages>(_apiKey));

        public async Task<GetBlockStorage> CreateBlockStorage(CreateBlockStorage instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .PostAsync<GetBlockStorage>(_apiKey, instance));

        public async Task<GetBlockStorage> GetBlockStorage(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetBlockStorage>(_apiKey));

        public async Task<IFlurlResponse> DeleteBlockStorage(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .AppendPathSegment(id)
                    .DeleteAsync(_apiKey));

        public async Task<IFlurlResponse> UpdateBlockStorage(string id, UpdateBlockStorage instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .AppendPathSegment(id)
                    .PatchAsync(instance, _apiKey));

        public async Task<IFlurlResponse> AttachBlockStorage(string id, AttachBlockStorage instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("attach")
                    .PostAsync(instance, _apiKey));

        public async Task<IFlurlResponse> DetachBlockStorage(string id, bool? live = null) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BlockStorageEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("detach")
                    .PostAsync(new { live }, _apiKey));

        public async Task<ListDomains> ListDomains() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .GetAsync<ListDomains>(_apiKey));

        public async Task<GetDomain> CreateDomain(CreateDomain domain) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .PostAsync<GetDomain>(_apiKey, domain));

        public async Task<GetDomain> GetDomain(string domain) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .GetAsync<GetDomain>(_apiKey));

        public async Task<IFlurlResponse> DeleteDomain(string domain) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .DeleteAsync(_apiKey));

        public async Task<IFlurlResponse> UpdateDomain(string domain, UpdateDomain dnsSec) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .PatchAsync(dnsSec, _apiKey));

        public async Task<GetSOAInformation> GetSOAInformation(string domain) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .AppendPathSegment("soa")
                    .GetAsync<GetSOAInformation>(_apiKey));

        public async Task<GetDNSRecord> CreateDNSRecord(string domain, CreateDNSRecord record) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .AppendPathSegment("records")
                    .PostAsync<GetDNSRecord>(_apiKey, record));

        public async Task<ListDNSRecords> ListDNSRecords(string domain) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .AppendPathSegment("records")
                    .GetAsync<ListDNSRecords>(_apiKey));

        public async Task<GetDNSRecord> GetDNSRecords(string domain, string recordId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .AppendPathSegment("records")
                    .AppendPathSegment(recordId)
                    .GetAsync<GetDNSRecord>(_apiKey));

        public async Task<IFlurlResponse> UpdateRecord(string domain, string recordId, UpdateDNSRecord record) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .AppendPathSegment("records")
                    .AppendPathSegment(recordId)
                    .PatchAsync(record, _apiKey));

        public async Task<IFlurlResponse> DeleteRecord(string domain, string recordId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(DNSEndpoint)
                    .AppendPathSegment(domain)
                    .AppendPathSegment("records")
                    .AppendPathSegment(recordId)
                    .DeleteAsync(_apiKey));

        public async Task<ListFirewallGroups> ListFirewallGroups() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .GetAsync<ListFirewallGroups>(_apiKey));

        public async Task<GetFirewallGroup> CreateFirewallGroup(string description) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .PostAsync<GetFirewallGroup>(_apiKey, new { description }));

        public async Task<GetFirewallGroup> GetFirewallGroup(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetFirewallGroup>(_apiKey));

        public async Task<IFlurlResponse> UpdateFirewallGroup(string id, string description) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(id)
                    .PatchAsync(new { description }, _apiKey));

        public async Task<IFlurlResponse> DeleteFirewallGroup(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(id)
                    .DeleteAsync(_apiKey));

        public async Task<ListFirewallRules> ListFirewallRules(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("rules")
                    .GetAsync<ListFirewallRules>(_apiKey));

        public async Task<GetFirewallRule> CreateFirewallRule(string id, CreateFirewallRule firewallRule) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("rules")
                    .PostAsync<GetFirewallRule>(_apiKey, firewallRule));

        public async Task<IFlurlResponse> DeleteFirewallRule(string groupId, string ruleId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(groupId)
                    .AppendPathSegment("rules")
                    .AppendPathSegment(ruleId)
                    .DeleteAsync(_apiKey));

        public async Task<GetFirewallGroup> GetFirewallRule(string groupId, string ruleId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(FirewallEndpoint)
                    .AppendPathSegment(groupId)
                    .AppendPathSegment("rules")
                    .AppendPathSegment(ruleId)
                    .GetAsync<GetFirewallGroup>(_apiKey));

        public async Task<ListInstances> ListInstances(
            int page = 150,
            string cursor = "",
            string label = "",
            string mainIP = "",
            string regionId = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .SetQueryParamIfAvailable("label", label)
                    .SetQueryParamIfAvailable("main_ip", mainIP)
                    .SetQueryParamIfAvailable("region", regionId)
                    .SetPagination(page, cursor)
                    .GetAsync<ListInstances>(_apiKey));

        public async Task<GetInstance> CreateInstance(CreateInstance instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .PostAsync<GetInstance>(_apiKey, instance));

        public async Task<GetInstance> GetInstance(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetInstance>(_apiKey));

        public async Task<GetInstance> UpdateInstance(string id, UpdateInstance instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .PatchAsync<GetInstance>(instance, _apiKey));

        public async Task<IFlurlResponse> DeleteInstance(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .DeleteAsync(_apiKey));

        public async Task<IFlurlResponse> HaltInstances(Instances instances) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment("halt")
                    .PostAsync(instances, _apiKey));

        public async Task<IFlurlResponse> RebootInstances(Instances instances) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment("reboot")
                    .PostAsync(instances, _apiKey));

        public async Task<IFlurlResponse> StartInstances(Instances instances) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment("start")
                    .PostAsync(instances, _apiKey));

        public async Task<IFlurlResponse> StartInstance(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("start")
                    .PostAsync(_apiKey));

        public async Task<IFlurlResponse> RebootInstance(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("reboot")
                    .PostAsync(_apiKey));

        public async Task<GetInstance> ReinstallInstance(string id, string? hostname = null) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("reinstall")
                    .PostAsync<GetInstance>(_apiKey, hostname));

        public async Task<BandwidthHistory> GetInstancelBandwidth(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("bandwidth")
                    .GetAsync<BandwidthHistory>(_apiKey));

        public async Task<Neighbors> GetInstanceNeighbors(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("neighbors")
                    .GetAsync<Neighbors>(_apiKey));

        public async Task<ListInstanceVPCs> ListInstanceVPCs(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("vpcs")
                    .GetAsync<ListInstanceVPCs>(_apiKey));

        public async Task<InstanceISOStatus> GetInstanceISOStatus(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("iso")
                    .GetAsync<InstanceISOStatus>(_apiKey));

        public async Task<InstanceISOStatus> AttachISOToInstance(string instanceId, AttachISO iso) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(instanceId)
                    .AppendPathSegment("iso")
                    .AppendPathSegment("attach")
                    .PostAsync<InstanceISOStatus>(_apiKey, iso));

        public async Task<IFlurlResponse> DetachISOFromInstance(string instanceId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(instanceId)
                    .AppendPathSegment("iso")
                    .AppendPathSegment("detach")
                    .PostAsync(_apiKey));

        public async Task<IFlurlResponse> AttachVPCToInstance(string instanceId, VPCId vpcId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(instanceId)
                    .AppendPathSegment("vpc")
                    .AppendPathSegment("attach")
                    .PostAsync(vpcId, _apiKey));

        public async Task<IFlurlResponse> DetachVPCFromInstance(string instanceId, VPCId vpcId) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(instanceId)
                    .AppendPathSegment("vpc")
                    .AppendPathSegment("detach")
                    .PostAsync(vpcId, _apiKey));

        public async Task<IFlurlResponse> SetInstanceBackupSchedule(string id, SetBackupSchedule backupSchedule) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("backup-schedule")
                    .PostAsync(backupSchedule, _apiKey));

        public async Task<GetBackupSchedule> GetInstanceBackupSchedule(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("backup-schedule")
                    .GetAsync<GetBackupSchedule>(_apiKey));

        public async Task<RestoreInstance> RestoreInstance(string instanceId, RestoreId restore) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(instanceId)
                    .AppendPathSegment("restore")
                    .PostAsync<RestoreInstance>(_apiKey, restore));

        public async Task<ListIPv4Information> ListInstanceIPv4Information(
            string id,
            bool? publicNetwork = null,
            int page = 100,
            string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv4")
                    .SetQueryParamIfAvailable("public_network", publicNetwork?.ToString())
                    .SetPagination(page, cursor)
                    .GetAsync<ListIPv4Information>(_apiKey));

        public async Task<GetInstanceIPv4> CreateIPv4ForInstance(string instanceId, bool reboot = true) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(instanceId)
                    .AppendPathSegment("ipv4")
                    .PostAsync<GetInstanceIPv4>(_apiKey, new { reboot }));

        public async Task<ListIPv6Information> ListInstanceIPv6Information(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv6")
                    .GetAsync<ListIPv6Information>(_apiKey));

        public async Task<IFlurlResponse> CreateReverseIPv6ForInstance(string id, ReverseEntry reverseEntry) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv6")
                    .AppendPathSegment("reverse")
                    .PostAsync(reverseEntry, _apiKey));

        public async Task<ListIPv6Reverse> ListInstanceIPv6Reverse(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv6")
                    .AppendPathSegment("reverse")
                    .GetAsync<ListIPv6Reverse>(_apiKey));

        public async Task<IFlurlResponse> CreateReverseIPv4ForInstance(string id, ReverseEntry reverseEntry) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv4")
                    .AppendPathSegment("reverse")
                    .PostAsync(reverseEntry, _apiKey));

        public async Task<GetUserData> GetInstanceUserData(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("user-data")
                    .GetAsync<GetUserData>(_apiKey));

        public async Task<IFlurlResponse> HaltInstance(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("halt")
                    .PostAsync(_apiKey));

        public async Task<IFlurlResponse> SetDefaultReverseDNSEntry(string id, string ip) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv4")
                    .AppendPathSegment("reverse")
                    .AppendPathSegment("default")
                    .PostAsync(new { ip }, _apiKey));
        
        public async Task<IFlurlResponse> DeleteIPv4FromInstance(string id, string ipv4) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv4")
                    .AppendPathSegment(ipv4)
                    .DeleteAsync(_apiKey));
        
        public async Task<IFlurlResponse> DeleteReverseIPv6ForInstance(string id, string ipv6) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv6")
                    .AppendPathSegment("reverse")
                    .AppendPathSegment(ipv6)
                    .DeleteAsync(_apiKey));
        
        public async Task<GetAvailableInstanceUpgrades> GetAvailableInstanceUpgrades(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(InstancesEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("upgrades")
                    .GetAsync<GetAvailableInstanceUpgrades>(_apiKey));


        private static T MakeRequest<T>(Func<T> f) => f();
    }
}