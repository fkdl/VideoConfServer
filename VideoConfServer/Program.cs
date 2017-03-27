using System;
using VideoConfServer.Core;
using VideoConfServer.Interfaces;

namespace VideoConfServer
{
    class Program
    {
        static void Main(string[] args)
        {
            IServer server = Environment.UserInteractive ?
                (IServer)(new ConsoleServer()) :
                (IServer)(new ServiceServer());
            server.Run();
        }
    }
}
