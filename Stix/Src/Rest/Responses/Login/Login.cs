using Newtonsoft.Json;

namespace Stix.Rest.Responses.Login
{
    public class Login
    {
        public int Id { get; set; }
        public string ScreenName { get; set; }
        public string Language { get; set; }
        [JsonProperty(PropertyName = "game_account_type")]
        public int GameAccountType { get; set; }
        [JsonProperty(PropertyName = "web_auth_token")]
        public string WebAuthToken { get; set; }
        public string GameAuthToken { get; set; }
        [JsonProperty(PropertyName = "game_server")]
        public GameServer GameServer { get; set; }
        public int ExpiryInDays { get; set; }
        public object Immortal { get; set; }
        public User User { get; set; }
    }
}