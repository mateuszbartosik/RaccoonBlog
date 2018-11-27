using System.Web;

namespace RaccoonBlog.Web.Helpers
{
    public static class CookieJar
    {
        private static HttpRequest CurrentRequest => HttpContext.Current.Request;
        private static HttpCookieCollection RequestCookies => CurrentRequest.Cookies;

        private static string GetRequestCookieText(string name)
        {
            var cookie = RequestCookies[name];
            return cookie?.Value;
        }

        private static bool? GetRequestCookieBool(string name)
        {
            var value = GetRequestCookieText(name);
            if (string.IsNullOrEmpty(value))
                return null;

            return bool.Parse(value);
        }

        private static int? GetRequestCookieInt(string name)
        {
            var value = GetRequestCookieText(name);
            if (string.IsNullOrEmpty(value))
                return null;

            return int.Parse(value);
        }

        public static bool? HideSidebar => GetRequestCookieBool(CookieNames.HideSidebar);
        public static int? VisitCount => GetRequestCookieInt(CookieNames.VisitCount);

        private static class CookieNames
        {
            public const string HideSidebar = "hideSidebar";
            public const string VisitCount = "visitCount";
        }
    }
}