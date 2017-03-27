using System;
using System.IO;
using TestSender.Helpers;
using WebSocketSharp;

namespace TestSender
{
    /// <summary>
    /// This test sender sends files.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            using (var ws = new WebSocket(AppConfig.ServerEndpoint))
            {
                ws.OnOpen += (sender, e) => Console.WriteLine("Socket Opened");
                ws.OnError += (sender, e) => Console.WriteLine("Socket Error: " + e.Message);
                ws.OnClose += (sender, e) => Console.WriteLine("Socket Closed: " + e.Reason);
                ws.ConnectAsync();

                CommandLoop(ws);
            }
        }

        private static void CommandLoop(WebSocket ws)
        {
            string command;
            while (true)
            {
                command = Console.ReadLine();
                if (command.CompareTo("exit") == 0)
                {
                    break;
                }
                if (ws.IsAlive)
                {
                    ws.SendAsync(File.ReadAllBytes(command), null);
                }
            }
        }
    }
}
