﻿using Microsoft.AspNetCore.Mvc;
using NWebsec.AspNetCore.Mvc.Csp;

namespace Mvc.Controllers
{
    [Csp,CspDefaultSrc(Self = true) ]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [TypeFilter(typeof(FlushTestAttribute))]
        public IActionResult Flush()
        {
            return View();
        }
    }
}
