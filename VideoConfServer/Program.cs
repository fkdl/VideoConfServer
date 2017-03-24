using System;
using VideoConfServer.Behaviors;
using VideoConfServer.Helpers;
using WebSocketSharp.Server;

namespace VideoConfServer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer listener = new WebSocketServer(AppConfig.ServerEndpoint);
            listener.AddWebSocketService<MainImageBehavior>(AppConfig.MainPath);
            listener.Start();

            CommandLoop();

            listener.Stop();
        }

        static void CommandLoop()
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
