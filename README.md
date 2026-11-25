# Artwork Fixer for Jellyfin

An admin-only Jellyfin dashboard page for finding movies and shows with **missing or low-resolution artwork** and replacing it, without leaving the page.

> **AI disclaimer:** This plugin was written with the help of an AI assistant (Claude, by Anthropic). It has not
> been compiled or run against a live Jellyfin server by its author, so expect to need a fix or two on first use.
> It is provided as is, with no warranty. Try it on one title first.

It does not depend on any other plugin or repository.

## What it does

- Scans your Movies and Shows and lists the ones with **no poster**, **no backdrop**, optionally **no logo**, or a **low-resolution** poster or backdrop (you choose the pixel thresholds).
- For each title, a **Fix artwork** window shows the alternative posters, backdrops and logos that your metadata sources offer, largest first, with their size, source and language. One click applies one.
- You can also **upload your own image**, **refresh the title's metadata**, or jump to its page.
- Image sizes are checked once per title and remembered in your browser, so later scans are quick. **Recheck sizes** clears that.

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
