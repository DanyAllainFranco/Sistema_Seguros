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
    public class ParentescoController : Controller
    {
        public ParentescoServices _parentescoServices;
        public ParentescoController(ParentescoServices parentescoServices)
        {
            _parentescoServices = parentescoServices;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var model = new List<ParentescoViewModel>();
                var list = await _parentescoServices.Index();
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
        public async Task<IActionResult> Insert(ParentescoViewModel item)
        {
            try
            {
                var list = await _parentescoServices.Insert(item);
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
        public async Task<IActionResult> Update(ParentescoViewModel item)
        {
            try
            {
                var list = await _parentescoServices.Update(item);
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
        public async Task<IActionResult> Delete(int Paren_Id)
        {
            try
            {
                var list = await _parentescoServices.Delete(Paren_Id);
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
                var model = new List<ParentescoViewModel>();
                var list = await _parentescoServices.Find();
                return View(list.Data);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Home");

            }
        }


        //GET:ParentescoController/Detalles/Parentesco
        public async Task<IActionResult> Details(int Paren_Id)
        {
            try
            {
                var result = await _parentescoServices.Details(Paren_Id);
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
