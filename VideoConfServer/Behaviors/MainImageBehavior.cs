using System.Linq;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace VideoConfServer.Behaviors
{
    /// <summary>
    /// Behavior for main image endpoint.
    /// Now it simple broadcasts the bytes to listeners.
    /// </summary>
    public class MainImageBehavior : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.IsBinary)
            {
                Sessions.Sessions
                    .Where(x => x.State == WebSocketState.Open && x.ID != ID)
                    .ToList()
                    .ForEach(x => Sessions.SendToAsync(e.RawData, x.ID, null));
            }
        }
    }
}
