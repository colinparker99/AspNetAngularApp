using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetAngularApp.Features.Group1.Feature1.Server.Controllers
{
    [Route("feature2")]
    public class Feature2Controller : Controller
    {
        public ActionResult Index()
        {
            return View("~/Features/dist/Group1/Feature2/Client/index.cshtml");
        }
    }
}