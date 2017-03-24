using System.Configuration;

namespace VideoConfServer.Helpers
{
    /// <summary>
    /// Wrapper class for working with App.config
    /// </summary>
    public static class AppConfig
    {
        /// <summary>
        /// Base server endpoint
        /// </summary>
        public static string ServerEndpoint
        {
            get
            {
                return ConfigurationManager.AppSettings["ServerEndpoint"];
            }
        }

        /// <summary>
        /// Path for main image endpoint (without rotations)
        /// </summary>
        public static string MainPath
        {
            get
            {
                return ConfigurationManager.AppSettings["MainPath"];
            }
        }
    }
}
