using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Resto.Models;
using Resto.ViewModels;

namespace Resto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new HomeViewModel
            {
                Carte = new Carte()
            };
            return View(model);
        }
    }
}