using Jellyfin.Plugin.ArtworkFixer.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.ArtworkFixer;

/// <summary>
/// Admin-only dashboard tool for finding titles with missing or low-resolution artwork and replacing it.
/// All of the work happens in the dashboard page, using Jellyfin's own image endpoints, which already
/// require an administrator.
/// </summary>
public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    public static Plugin? Instance { get; private set; }

    public override string Name => "Artwork Fixer";

    public override Guid Id => Guid.Parse("8738f582-1c94-405b-9bf5-14b5739f0a00");

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return new[]
        {
            new PluginPageInfo
            {
                Name = "artworkfixer",
                DisplayName = "Artwork Fixer",
                EmbeddedResourcePath = GetType().Namespace + ".Pages.artworkfixer.html",
                EnableInMainMenu = true,
                MenuSection = "server",
                MenuIcon = "image"
            }
        };
    }
}
