using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resto.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Restaurant()
        {
            return View();
        }
    }
}