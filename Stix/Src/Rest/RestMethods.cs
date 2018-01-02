using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Stix.Client;
using Stix.Util;

namespace Stix.Rest
{
    public static class RestMethods
    {
        public static async Task Login(string username, string password)
        {
            var response = await Rest.Post(Constants.Endpoints.Login, new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("screen_name", username),
                new KeyValuePair<string, string>("password", password)
            }));

            if (response == null) throw new HttpRequestException("Login failed!");

            // Handle login response
            ClientManager.HandleLoginResponse(response);
        }
    }
}