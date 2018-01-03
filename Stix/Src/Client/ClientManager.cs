using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Stix.Network;

namespace Stix.Client
{
    public static class ClientManager
    {
        public static async Task HandleLoginResponseAsync(string response)
        {
            var login = JsonConvert.DeserializeObject<Rest.Responses.Login.Login>(response);

            // Create client
            var client = new Client(login);

            // Connect
            Connect(client);
        }

        private static async void Connect(Client client)
        {
            var response = await client.Connect(client.Player.SmartFoxServer);
            if (response == ConnectionState.Connected)
            {
                if (!Session.Session.Sessions.ContainsKey(client.Player.ScreenName))
                    Session.Session.Sessions.TryAdd(client.Player.ScreenName, client);
            }
        }
    }
}