using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreMvcRouting.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcRouting.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index() => View("Result", new Result { Controller = nameof(AdminController), Action = nameof(Index) });
    }
}