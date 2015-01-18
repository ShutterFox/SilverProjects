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
        [HttpGet]
        public ActionResult Index()
        {
            var viewModel = new MPGIndexViewModel();
            

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(MPGIndexViewModel viewModel)
        {
            decimal LIT_GAL_CONV = 4.54m;
            decimal litresPumped, gallonsPumped;
            litresPumped = viewModel.CostPumped / viewModel.CostPerL;
            gallonsPumped = litresPumped / LIT_GAL_CONV;
            var result = viewModel.Miles / gallonsPumped;
            viewModel.Result = Math.Round(result, 2);

            return View(viewModel);
        }
    }
}