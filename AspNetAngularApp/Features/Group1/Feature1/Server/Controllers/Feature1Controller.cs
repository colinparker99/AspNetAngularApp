using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetAngularApp.Features.Group1.Feature1.Server.Controllers
{
    [Route("feature1")]
    public class Feature1Controller : Controller
    {
        public ActionResult Index()
        {
            //return View("~/Features/Group1/Feature1/Client/index.cshtml");
            return View("~/Features/dist/Group1/Feature1/Client/index.cshtml");
        }
    }
}