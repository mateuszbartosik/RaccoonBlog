using System.Web.Mvc;

namespace RaccoonBlog.Web.Controllers
{
    public class LegalController : RaccoonController
    {
        [HttpGet]
        [Route("privacy-policy")]
        public virtual ActionResult PrivacyPolicy()
        {
            return View("PrivacyPolicy");
        }

        [HttpGet]
        [Route("terms")]
        public virtual ActionResult Terms()
        {
            return View("Terms");
        }
    }
}