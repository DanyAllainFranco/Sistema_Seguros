using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class PolizaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
