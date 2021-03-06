﻿using System;
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
            if (!ModelState.IsValid)
            {
                return this.View(viewModel);
            }

            const decimal LIT_GAL_CONV = 4.54m;
            var litresPumped = viewModel.CostPumped / viewModel.CostPerL;
            var gallonsPumped = litresPumped / LIT_GAL_CONV;
            var result = viewModel.Miles / gallonsPumped;
            viewModel.Result = Math.Round(result, 2);
            viewModel.CanShowResult = true;
            return View(viewModel);
        }
    }
}