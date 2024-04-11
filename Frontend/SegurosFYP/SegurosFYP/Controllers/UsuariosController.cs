using Microsoft.AspNetCore.Mvc;
using SegurosFYP.Common.Models;
using SegurosFYP.Models;
using SegurosFYP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class UsuariosController : Controller
    {
        public UsuarioService _UsuarioService;
        public UsuariosController(UsuarioService usuarioService)
        {
            _UsuarioService = usuarioService;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<UsuarioViewModel>();
                var list = await _UsuarioService.Index();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(UsuarioViewModel item , int Roles_Id)
        {
            if (item.Usuar_Admin == true)
            {
                item.Roles_Id = 12;
            }
            else
            {
                Roles_Id = item.Roles_Id;
            }
            try           
            {
                var list = await _UsuarioService.Insert(item);
                TempData["Exito"] = "Registro insertado con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al insertar";
                return View(item);
            }
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(UsuarioViewModel item, int Roles_Id)
        {
            if (item.Usuar_Admin == true)
            {
                item.Roles_Id = 12;
            }
            else
            {
                Roles_Id = item.Roles_Id;
            }
            try
            {
                var list = await _UsuarioService.Update(item);
                TempData["Exito"] = "Registro editado con exito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al editar";
                return View(item);
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Usuar_Id)
        {
            try
            {
                var list = await _UsuarioService.Delete(Usuar_Id);
                TempData["Exito"] = "Registro eliminado con éxito";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al eliminar";
                return RedirectToAction("Index");
            }
        }



        public async Task<IActionResult> Find()
        {
            try
            {
                var model = new List<UsuarioViewModel>();
                var list = await _UsuarioService.Find();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }


        //GET:Usuariocontroller/Detalles/Usuario
        public async Task<IActionResult> Details(int Usuar_Id)
        {
            try
            {
                var result = await _UsuarioService.Details(Usuar_Id);
                if (result.Success)
                {
                    return View(result.Data);
                }
                else
                {
                    TempData["Error"] = result.Message;
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error al obtener los detalles del estado civil";
                return RedirectToAction("Index");
            }
        }

    }
}
