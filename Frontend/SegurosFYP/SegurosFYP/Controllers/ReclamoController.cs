﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReclamoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
