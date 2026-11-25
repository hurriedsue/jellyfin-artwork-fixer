# Artwork Fixer for Jellyfin

Artwork Fixer adds an admin-only page to the Jellyfin dashboard. It helps you find movies and shows whose artwork is missing or too small, and replace it without leaving the page.

> **AI disclaimer:** This plugin was written with the help of an ClaudeAI and tested
> only on one personal Jellyfin 12.4 server. It may contain bugs or behave differently elsewhere. It is provided
> as is, with no warranty. Try it on one title first. I can read and write code, I just opted to speed up the process via vibecoding but every change is reviewed manually by a human.

It does not depend on any other plugin or repository.

## How it works

1. **Scan.** Press **Scan Library**. The page reads your movies and shows and lists every title that has a problem: no poster, no backdrop, no logo (optional), or a poster or backdrop narrower than the size you set in Settings. The width of each image is checked once and remembered in your browser, so later scans are quick.
2. **Choose a title.** Use the filters to narrow the list, then press **Fix Artwork…** on a title.
3. **Pick a replacement.** The window shows the alternative posters, backdrops and logos that Jellyfin's metadata sources offer for that title. They are sorted with your preferred language first, then by rating, then by size. You can also sort by rating or size only, or filter by language. Press **Use This** and Jellyfin downloads and applies that image.
4. **Other options.** If nothing suitable is offered, you can upload your own image, or press **Refresh Metadata** to ask Jellyfin to look again. **Open Title Page** takes you to the title.

The page does not store images or keep a database of its own. It uses Jellyfin's built-in image functions, so anything you change appears exactly as if you had used Jellyfin's own image editor.

## Who can use it

Only administrators. The page lives in the dashboard, and every action it takes (listing remote images, downloading or uploading an image) goes through Jellyfin's own image endpoints, which require an administrator account.

## Install (recommended: through Jellyfin)

1. In Jellyfin go to **Dashboard → Plugins → Repositories → +** and add:
   - Name: `Artwork Fixer`
   - URL: `https://raw.githubusercontent.com/hurriedsue/jellyfin-plugin-artwork-fixer/main/manifest.json`
2. Open the **Catalog**, find **Artwork Fixer** under General, and install it.
3. Restart Jellyfin. **Artwork Fixer** then appears in the dashboard's left-hand menu.

## Install (manual)

1. Download `ArtworkFixer_x.x.x.x.zip` from the latest **Release**.
2. Unzip it into a new folder inside your Jellyfin plugins folder, for example `C:\ProgramData\Jellyfin\Server\plugins\ArtworkFixer_1.0.0.0\`.
3. Restart Jellyfin.

Built for **Jellyfin 12.x** (`targetAbi 12.0.0.0`, .NET 10).

## Releasing a version

Change `<Version>` in `Jellyfin.Plugin.ArtworkFixer/Jellyfin.Plugin.ArtworkFixer.csproj`, then push a tag such as `v1.0.1.0`. The **Build** workflow builds the plugin, attaches the zip to a release, and adds the new version to `manifest.json` so Jellyfin offers it as an update.

## Settings

Under **Settings** on the page: the poster and backdrop widths below which an image counts as low-resolution (defaults 600 and 1280 pixels), whether to check sizes at all, and whether to list titles with no logo.

## Licence

MIT. See `LICENSE`.
