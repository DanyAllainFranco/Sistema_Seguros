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
    public class CargoController : Controller
    {
        public CargosServices _cargosServices;
        public CargoController(CargosServices CargoServices)
        {
            _cargosServices = CargoServices;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<CargosViewModel>();
                var list = await _cargosServices.Index();
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
        public async Task<IActionResult> Insert(CargosViewModel item)
        {
            try
            {
                var list = await _cargosServices.Insert(item);
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
        public async Task<IActionResult> Update(CargosViewModel item)
        {
            try
            {
                var list = await _cargosServices.Update(item);
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
        public async Task<IActionResult> Delete(int Cargo_Id)
        {
            try
            {
                var list = await _cargosServices.Delete(Cargo_Id);
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
                var model = new List<CargosViewModel>();
                var list = await _cargosServices.Find();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }


        //GET:Cargocontroller/Detalles/Cargo
        public async Task<IActionResult> Details(int Cargo_Id)
        {
            try
            {
                var result = await _cargosServices.Details(Cargo_Id);
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
