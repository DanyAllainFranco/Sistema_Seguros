using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.Models;
using SegurosFYP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class PolizaController : Controller
    {
        private readonly PolizaServices _polizaServices;

        public PolizaController(PolizaServices polizaServices)
        {
            _polizaServices = polizaServices;
        }

        public IActionResult Index()
        {
            var list = _polizaServices.Index();
            
            return View(list);
        }
    }
}
