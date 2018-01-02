using System;
using System.Net.Http;
using System.Threading.Tasks;
using Stix.Util;

namespace Stix.Rest
{
    public static class Rest
    {
        public static async Task<string> Post(string url, FormUrlEncodedContent form)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Constants.Endpoints.Host);

                var response = await client.PostAsync(url, form);
                if (response.IsSuccessStatusCode) return await response.Content.ReadAsStringAsync();
                return null;
            }
        }
    }
}