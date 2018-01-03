using DotNetty.Codecs;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;

namespace Stix.Network
{
    public class Initializer : ChannelInitializer<ISocketChannel>
    {
        protected override void InitChannel(ISocketChannel channel)
        {
            channel.Pipeline.AddLast("framer", new DelimiterBasedFrameDecoder(1024, false, Delimiters.NullDelimiter()));
            channel.Pipeline.AddLast("decoder", new StringDecoder());
            channel.Pipeline.AddLast("encoder", new StringEncoder());
            channel.Pipeline.AddLast("handler", new Handler());
        }
    }
}