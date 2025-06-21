using DiscordRPC;
using PresenceCommon.Types;

namespace PresenceCommon
{
    public static class Utils
    {
        public static RichPresence CreateDiscordPresence(Title title, Timestamps time, string state = "", string largeImageUrl = null)
        {
            RichPresence presence = new RichPresence()
            {
                State = state
            };

            Assets assets = new Assets {};

            if (title.Index == 0)
            {
                assets.LargeImageText = "LiveArea";
                assets.LargeImageKey = "invalid";
                presence.Details = "In the LiveArea";
            }
            else
            {
                assets.LargeImageText = title.TitleName;
                assets.LargeImageKey = largeImageUrl != null ? $"https:{largeImageUrl}" : "invalid";
                presence.Details = $"{title.TitleName}";
            }
            presence.Assets = assets;
            presence.Timestamps = time;

            return presence;
        }
    }
}
