using System.Web;

namespace RaccoonBlog.Web.Helpers
{
    public class SidebarHelper
    {
        private const int VisitCountMax = 10;

        private static HttpRequest CurrentRequest => HttpContext.Current.Request;

        public static bool ShouldShowSidebar()
        {
            var hasExplicitlyHidden = CookieJar.HideSidebar;
            if (hasExplicitlyHidden == true)
                return false;

            var isOnMainPage = CurrentRequest.Path == "/";
            if (isOnMainPage)
                return true;

            var visitCount = CookieJar.VisitCount.GetValueOrDefault();
            return visitCount < VisitCountMax;
        }
    }
}