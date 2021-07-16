using Resto.Models;
using Resto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resto.Controllers
{
    public class CarteController : Controller
    {
        // GET: Carte
        public ActionResult Index()
        {
            var model = new CarteViewModel
            {
                Carte = new Carte()
            };
            return View(model);
        }
    }
}