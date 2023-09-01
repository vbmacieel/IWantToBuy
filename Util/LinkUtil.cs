namespace IWantToBuy.Util
{
    public class LinkUtil
    {
        public static bool isValidUrl(string url) =>
            Uri.IsWellFormedUriString(url, UriKind.Absolute);

        public static bool isImgValidUrl(string url)
        {
            if (!isValidUrl(url))
            {
                return false;
            }

            if (!(url.Contains(".png") || url.Contains(".jpg")))
            {
                return false;
            }
            return true;
        }
    }
}