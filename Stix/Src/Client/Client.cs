using System;
using System.Threading.Tasks;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;
using Stix.Client.Game;
using Stix.Network;

namespace Stix.Client
{
    public class Client
    {
        private static readonly Initializer Initializer = new Initializer();
        private static readonly MultithreadEventLoopGroup EventLoop = new MultithreadEventLoopGroup();
        private static readonly Bootstrap Bootstrap = new Bootstrap();

        public Player Player = new Player();
        private IChannel Channel;

        static Client()
        {
            Bootstrap.Group(EventLoop);
            Bootstrap.Channel<TcpSocketChannel>();
            Bootstrap.Handler(Initializer);
        }

        public Client(Rest.Responses.Login.Login loginInformation)
        {
            Player.SetInformation(loginInformation);
        }

        public async Task<ConnectionState> Connect(string host)
        {
            Channel = await Bootstrap.ConnectAsync(host, 443);
            if (Channel.Open)
            {
                Console.WriteLine("Connected");
                return Network.ConnectionState.Connected;
            }
            return ConnectionState.Failed;
        }
    }
}