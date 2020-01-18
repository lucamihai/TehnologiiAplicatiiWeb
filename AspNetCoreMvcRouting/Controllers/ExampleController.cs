using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcRouting.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = "Hello"; 
            ViewBag.Date = DateTime.Now; 
            
            return View();
        }

        public ViewResult Result() => View((object)"Hello World");

        public RedirectToActionResult Redirect() => RedirectToAction(nameof(Index));
    }
}