using System;
using DotNetty.Transport.Channels;

namespace Stix.Network
{
    public class Handler : ChannelHandlerAdapter
    {
        public override void HandlerAdded(IChannelHandlerContext context)
        {
           
        }

        public override void ChannelInactive(IChannelHandlerContext context)
        {
           
        }

        public override void ChannelRead(IChannelHandlerContext context, object message)
        {
            var data = message as string;
            Console.WriteLine(data);
        }

        public override void ChannelReadComplete(IChannelHandlerContext context) => context.Flush();
    }
}