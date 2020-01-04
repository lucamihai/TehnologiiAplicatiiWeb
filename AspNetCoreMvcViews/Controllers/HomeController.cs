﻿using System.Collections.Generic;
using AspNetCoreMvcViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcViews.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository; 
        public HomeController(IRepository repo) { repository = repo; }

        public IActionResult Index([FromQuery] int? id)
        {
            Person person;
            if (id.HasValue && (person = repository[id.Value]) != null)
            {
                return View(person);
            }
            else
            {
                return NotFound();
            }
        }
        public ViewResult Create() => View(new Person());

        [HttpPost] 
        public ViewResult Create(Person model) => View("Index", model);
        public ViewResult Names(IList<string> names) => View(names ?? new List<string>());
    }
}
