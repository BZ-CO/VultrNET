using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Flurl.Util;

namespace VultrNET.Utils
{
    public static class Extensions
    {
        public static Task<IFlurlResponse> GetAsync(this Url url, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .GetAsync();
        }

        public static Task<T> GetAsync<T>(this Url url, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .GetJsonAsync<T>();
        }

        public static Task<T> PostAsync<T>(this Url url, string token, object? body = null)
        {
            return body is null
                ? url
                    .WithOAuthBearerToken(token)
                    .PostAsync()
                    .ReceiveJson<T>()
                : url
                    .WithOAuthBearerToken(token)
                    .PostJsonAsync(body)
                    .ReceiveJson<T>();
        }

        public static Task<IFlurlResponse> PostAsync(this Url url, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .PostAsync();
        }

        public static Task<IFlurlResponse> PostAsync(this Url url, object body, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .PostJsonAsync(body);
        }

        public static Task<IFlurlResponse> PatchAsync(this Url url, object body, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .PatchJsonAsync(body);
        }

        public static Task<T> PatchAsync<T>(this Url url, object body, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .PostJsonAsync(body)
                .ReceiveJson<T>();
        }

        public static Task<IFlurlResponse> DeleteAsync(this Url url, string token)
        {
            return url
                .WithOAuthBearerToken(token)
                .DeleteAsync();
        }

        public static Url SetQueryParamIfAvailable(this Url url, string? name = null, string? value = null)
        {
            return string.IsNullOrEmpty(value) ? url : url.SetQueryParam(name, value);
        }

        public static Url SetPagination(this Url url, int page, string? cursor = null)
        {
            url.SetQueryParam("per_page", page.ToInvariantString());
            if (!string.IsNullOrEmpty(cursor))
            {
                url.SetQueryParam("cursor", cursor);
            }

            return url;
        }
    }
}