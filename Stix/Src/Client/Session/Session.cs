using System.Collections.Concurrent;

namespace Stix.Client.Session
{
    public static class Session
    {
        public static ConcurrentDictionary<string, Client> Sessions = new ConcurrentDictionary<string, Client>();
    }
}