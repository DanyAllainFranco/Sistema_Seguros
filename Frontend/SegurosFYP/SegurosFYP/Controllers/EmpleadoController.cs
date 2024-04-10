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
    public class EmpleadoController : Controller
    {
        public EmpleadoServices _empleadoServices;
        public PersonaServices _personaServices;
        public EmpleadoController(EmpleadoServices empleadoServices, PersonaServices personaServices)
        {
            _empleadoServices = empleadoServices;
            _personaServices = personaServices;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<EmpleadoViewModel>();
                var list = await _empleadoServices.Index();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(EmpleadoViewModel item)
        {
            try
            {
                await _personaServices.Insert(item);
                var list = await _empleadoServices.Insert(item);
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
        public async Task<IActionResult> Update(EmpleadoViewModel item)
        {
            try
            {
                var list = await _empleadoServices.Update(item);
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
        public async Task<IActionResult> Delete(int Emple_Id)
        {
            try
            {
                var list = await _empleadoServices.Delete(Emple_Id);
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
                var model = new List<EmpleadoViewModel>();
                var list = await _empleadoServices.Find();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }


        //GET:Empleadocontroller/Detalles/Empleado
        public async Task<IActionResult> Details(int Emple_Id)
        {
            try
            {
                var result = await _empleadoServices.Details(Emple_Id);
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
