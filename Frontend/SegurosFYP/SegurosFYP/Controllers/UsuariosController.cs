using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index(List<UsuariosViewModel> usuarios)
        {
            return View(usuarios);
        }
    }
}
