using MediaBrowser.Model.Plugins;

namespace Veso.Plugin.OpenSubtitles.Configuration
{
    public class PluginConfiguration : BasePluginConfiguration
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
