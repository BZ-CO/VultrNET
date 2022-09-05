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

        public async Task<GetBareMetalBandwidth> GetBareMetalBandwidth(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("bandwidth")
                    .GetAsync<GetBareMetalBandwidth>(_apiKey));

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

        public async Task<GetBareMetalUserData> GetBareMetalUserData(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("user-data")
                    .GetAsync<GetBareMetalUserData>(_apiKey));

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
                    .PostAsync(new { live}, _apiKey));

        private static T MakeRequest<T>(Func<T> f) => f();
    }
}