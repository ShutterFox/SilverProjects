using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SilverProjects.Controllers
{
    using System.Dynamic;

    using SilverProjects.Models;

    public class MPGController : Controller
    {
        // GET: MPG
        public ActionResult Index()
        {
            var viewModel = new MPGIndexViewModel();
            viewModel.Bob = "butts";

            return View(viewModel);
        }
    }
}