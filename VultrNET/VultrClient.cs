using System;
using System.Diagnostics.SymbolStore;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Http.Configuration;
using Flurl.Util;
using VultrNET.Models.Account;
using VultrNET.Models.Applications;
using VultrNET.Models.Backups;
using VultrNET.Models.BareMetals;
using VultrNET.Models.BareMetals.Requests;

namespace VultrNET
{
    public class VultrClient
    {
        private const string BaseUrl = "https://api.vultr.com/v2";
        private const string AccountEndpoint = "account";
        private const string ApplicationsEndoint = "applications";
        private const string BackupsEndpoint = "backups";
        private const string BareMetalsEndpoint = "bare-metals";
        private readonly string _token;

        public VultrClient(string token)
        {
            _token = token;
            FlurlHttp.Configure(x => { x.BeforeCallAsync = BeforeCallAsync; });
        }

        private Task BeforeCallAsync(FlurlCall arg)
        {
            return Task.CompletedTask;
        }

        public async Task<GetAccountInfo> GetAccountInfoAsync() =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(AccountEndpoint)
                    .GetAsync<GetAccountInfo>(_token));

        public async Task<ListApplications> ListApplications(
            string applicationType, int page = 150, string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(ApplicationsEndoint)
                    .SetQueryParamIfAvailable("type", applicationType.ToLowerInvariant())
                    .SetPagination(page, cursor)
                    .GetAsync<ListApplications>(_token));

        public async Task<ListBackups> ListBackups(string id = "", int page = 100, string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BackupsEndpoint)
                    .SetQueryParamIfAvailable("instance_id", id)
                    .SetPagination(page, cursor)
                    .GetAsync<ListBackups>(_token));

        public async Task<GetBackup> GetBackup(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BackupsEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetBackup>(_token));

        public async Task<ListBareMetalInstances> ListBareMetalInstances(int page = 100, string cursor = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .SetPagination(page, cursor)
                    .GetAsync<ListBareMetalInstances>(_token));

        public async Task<BareMetal> CreateBareMetalInstance(CreateBareMetal instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .PostAsync<BareMetal>(_token, instance));

        public async Task<GetBareMetal> GetBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .GetAsync<GetBareMetal>(_token));

        public async Task<IFlurlResponse> UpdateBareMetal(string id, UpdateBareMetal instance) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .PatchAsync(instance, _token));

        public async Task<IFlurlResponse> DeleteBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .DeleteAsync(_token));

        public async Task<BareMetalIPv4Addresses> GetBareMetalIPv4Addresses(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv4")
                    .GetAsync<BareMetalIPv4Addresses>(_token));

        public async Task<BareMetalIPv6Addresses> GetBareMetalIPv6Addresses(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("ipv6")
                    .GetAsync<BareMetalIPv6Addresses>(_token));

        public async Task<IFlurlResponse> StartBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("start")
                    .PostAsync(_token));
        
        public async Task<IFlurlResponse> RebootBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("reboot")
                    .PostAsync(_token));
        
        public async Task<ReinstallBareMetal> ReinstallBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("reinstall")
                    .PostAsync<ReinstallBareMetal>(_token));
        
        public async Task<IFlurlResponse> HaltBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("halt")
                    .PostAsync(_token));
        
        public async Task<GetBareMetalBandwidth> GetBareMetalBandwidth(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("bandwidth")
                    .GetAsync<GetBareMetalBandwidth>(_token));
        
        public async Task<IFlurlResponse> HaltBareMetals(BareMetals ids) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment("halt")
                    .PostAsync(_token));
        
        public async Task<IFlurlResponse> RebootMetals(BareMetals ids) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment("reboot")
                    .PostAsync(_token));
        
        public async Task<IFlurlResponse> StartBareMetals(BareMetals ids) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment("start")
                    .PostAsync(_token));
        
        public async Task<GetBareMetalUserData> GetBareMetalUserData(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("user-data")
                    .GetAsync<GetBareMetalUserData>(_token));
        
        public async Task<GetAvailableBareMetalUpgrades> GetAvailableUpgradesForBareMetal(string id, string type = "") =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("upgrades")
                    .SetQueryParamIfAvailable("type", type.ToLowerInvariant())
                    .GetAsync<GetAvailableBareMetalUpgrades>(_token));
        
        public async Task<GetVNCBareMetal> GetAvailableUpgradesForBareMetal(string id) =>
            await MakeRequest(() =>
                BaseUrl
                    .AppendPathSegment(BareMetalsEndpoint)
                    .AppendPathSegment(id)
                    .AppendPathSegment("vnc")
                    .GetAsync<GetVNCBareMetal>(_token));

        private static T MakeRequest<T>(Func<T> f) => f();
    }
}