# Artwork Fixer for Jellyfin

Artwork Fixer adds an admin-only page to the Jellyfin dashboard. It helps you find movies and shows whose artwork is missing or too small, and replace it without leaving the page.

> **Disclosure:** This plugin was developed with the assistance of an AI model (Claude, by Anthropic). The author
> can read and write code and chose AI-assisted development to speed up the process; every change is reviewed
> manually by a human. It has been tested on a single Jellyfin 12.4 installation and is provided as is, without
> warranty of any kind. Test it on one title before relying on it.

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

## Settings

Under **Settings** on the page: the poster and backdrop widths below which an image counts as low-resolution (defaults 600 and 1280 pixels), whether to check sizes at all, and whether to list titles with no logo.

## Licence

MIT. See `LICENSE`.
