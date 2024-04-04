using Microsoft.AspNetCore.Mvc;
using SegurosFYP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index(List<UsuarioViewModel> usuarios)
        {
            return View(usuarios);
        }
    }
}
