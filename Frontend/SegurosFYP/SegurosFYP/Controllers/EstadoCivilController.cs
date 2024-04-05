using Microsoft.AspNetCore.Mvc;
using SegurosFYP.Models;
using SegurosFYP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Controllers
{
    public class EstadoCivilController : Controller
    {
        public EstadoCivilServices _estadoCivilServices;
        public EstadoCivilController(EstadoCivilServices estadoCivilServices)
        {
            _estadoCivilServices = estadoCivilServices;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<EstadoCivilViewModel>();
                var list = await _estadoCivilServices.Index();
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
        public async Task<IActionResult> Insert(EstadoCivilViewModel item)
        {
            try
            { 
                var list = await _estadoCivilServices.Insert(item);
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
        public async Task<IActionResult> Update(EstadoCivilViewModel item)
        {
            try
            {
                var list = await _estadoCivilServices.Update(item);
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
        public async Task<IActionResult> Delete(int Estad_Id)
        {
            try
            {
                var list = await _estadoCivilServices.Delete(Estad_Id);
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
                var model = new List<EstadoCivilViewModel>();
                var list = await _estadoCivilServices.Find();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }


        public ActionResult Details()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Details(int id)
        {
            try
            {
                var result = await _estadoCivilServices.Details(id);
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
