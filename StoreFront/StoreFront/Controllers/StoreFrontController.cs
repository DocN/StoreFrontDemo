using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace StoreFront.Controllers
{
    public class StoreFrontController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}