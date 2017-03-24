using System;
using System.IO;
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
            using (var ws = new WebSocket("ws://localhost:8888/main"))
            {
                ws.Connect();

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

                ws.SendAsync(File.ReadAllBytes(command), null);
            }
        }
    }
}
