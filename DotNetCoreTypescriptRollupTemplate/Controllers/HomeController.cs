using System;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreTypescriptRollupTemplate
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Hello world!";
            ViewBag.Time = DateTime.Now;

            return View();
        }
    }
}