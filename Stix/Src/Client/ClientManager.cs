using System;
using Newtonsoft.Json;

namespace Stix.Client
{
    public static class ClientManager
    {
        public static void HandleLoginResponse(string response)
        {
            var login = JsonConvert.DeserializeObject<Rest.Responses.Login.Login>(response);
            
            // Todo handle login
        }
    }
}