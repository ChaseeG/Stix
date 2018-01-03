using System;

namespace Stix.Client.Game
{
    public class Player
    {
        public int Id { get; private set; }
        public string ScreenName { get; private set; }
        public string SmartFoxServer { get; private set; }
        public string GameAuthToken { get; private set; }

        public void SetInformation(Rest.Responses.Login.Login login)
        {
            Console.WriteLine(login.ScreenName);
            Id = login.User.Id;
            ScreenName = login.ScreenName;
            GameAuthToken = login.GameAuthToken;
            SmartFoxServer = login.GameServer.SmartfoxServer;
        }
    }
}