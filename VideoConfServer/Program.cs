using System;
using VideoConfServer.Core;
using VideoConfServer.Interfaces;

namespace VideoConfServer
{
    class Program
    {
        /// <summary>
        /// Entry Point. It launches Console or Service Server based on environment.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IServer server = Environment.UserInteractive ?
                (IServer)(new ConsoleServer()) :
                (IServer)(new ServiceServer());
            server.Run();
        }
    }
}
