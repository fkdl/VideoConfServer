using System;
using VideoConfServer.Behaviors;
using VideoConfServer.Helpers;
using VideoConfServer.Interfaces;
using WebSocketSharp.Server;

namespace VideoConfServer.Core
{
    /// <summary>
    /// Represents server as Windows Console Standalone Application.
    /// </summary>
    public class ConsoleServer : IServer
    {
        public void Run()
        {
            WebSocketServer listener = new WebSocketServer(AppConfig.ServerEndpoint);
            listener.AddWebSocketService<MainImageBehavior>(AppConfig.MainPath);
            listener.Start();

            CommandLoop();

            listener.Stop();
        }

        private void CommandLoop()
        {
            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command.CompareTo("exit") == 0)
                {
                    break;
                }
            }
        }
    }
}
