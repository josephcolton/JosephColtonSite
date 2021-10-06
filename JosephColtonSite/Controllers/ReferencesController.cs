using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JosephColtonSite.Controllers
{
    public class ReferencesController : Controller
    {
        public IActionResult References()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View();
        }

    }
}
