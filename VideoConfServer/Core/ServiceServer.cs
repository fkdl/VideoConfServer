using VideoConfServer.Behaviors;
using VideoConfServer.Helpers;
using VideoConfServer.Interfaces;
using WebSocketSharp.Server;
using System.ServiceProcess;

namespace VideoConfServer.Core
{
    /// <summary>
    /// Represents server as Windows Service.
    /// </summary>
    public class ServiceServer : ServiceBase, IServer
    {
        WebSocketServer listener;

        public void Run()
        {
            Run(this);
        }

        protected override void OnStart(string[] args)
        {
            if (listener == null)
            {
                listener = new WebSocketServer(AppConfig.ServerEndpoint);
                listener.AddWebSocketService<MainImageBehavior>(AppConfig.MainPath);
            }
            listener.Start();
        }

        protected override void OnStop()
        {
            listener.Stop();
        }
    }
}
