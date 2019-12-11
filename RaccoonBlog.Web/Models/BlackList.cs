namespace RaccoonBlog.Web.Models
{
    public class BlackList
    {
        public static string GetId(string ipAddress)
        {
            return "BlackList/" + ipAddress;
        }
    }
}