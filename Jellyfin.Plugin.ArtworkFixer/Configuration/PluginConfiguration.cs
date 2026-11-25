using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.ArtworkFixer.Configuration;

/// <summary>
/// Settings saved by the Artwork Fixer page.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>Gets or sets the poster width, in pixels, below which a poster counts as low resolution.</summary>
    public int MinPosterWidth { get; set; } = 600;

    /// <summary>Gets or sets the backdrop width, in pixels, below which a backdrop counts as low resolution.</summary>
    public int MinBackdropWidth { get; set; } = 1280;

    /// <summary>Gets or sets a value indicating whether image sizes are checked (one request per title, cached).</summary>
    public bool CheckResolution { get; set; } = true;

    /// <summary>Gets or sets a value indicating whether titles with no logo are listed.</summary>
    public bool FlagMissingLogo { get; set; } = false;
}
