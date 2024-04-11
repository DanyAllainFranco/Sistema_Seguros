using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System.Collections.Generic;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly InsuranceServices _insuranceServices;
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EmpleadoController(InsuranceServices insuranceServices, GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }

        [HttpGet("List/Empleados")]
        public IActionResult ListEmpleados()
        {
            var list = _insuranceServices.ListEmpleados();
            return Ok(list);
        }

        [HttpPost("Insert/Empleados")]
        public IActionResult InsertEmpleados(EmpleadoViewModel item)
        {
            var id = _generalServices.NumerationPerso(1);
            var modelo = new tbEmpleados()
            {
                Emple_Id = id.Data,
                Cargo_Id = item.Cargo_Id
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _insuranceServices.InsertEmpleados(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Empleados")]
        public IActionResult UpdateEmpleados(EmpleadoViewModel item)
        {
            var model = _mapper.Map<tbEmpleados>(item);
            var modelo = new tbEmpleados()
            {
                Cargo_Id = item.Cargo_Id
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _insuranceServices.UpdateEmpleados(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Empleados")]
        public IActionResult DeleteEmpleados(int Emple_Id)
        {
            var list = _insuranceServices.DeleteEmpleados(Emple_Id);
            return Ok(list);
        }
        [HttpGet("DropDownList/Empleados")]
        public IActionResult DropDownList()
        {
            var list = _insuranceServices.DropDownListEmple();

            return Ok(list);
        }
        [HttpGet("Cargar/Empleados")]
        public IActionResult CargarEmpleados(int Emple_Id)
        {
            var list = _insuranceServices.CargarEmpleados(Emple_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Empleados")]
        public IActionResult DetallesEmpleados(int Emple_Id)
        {
            var list = _insuranceServices.DetallesEmpleados(Emple_Id);

            return Ok(list);
        }

    }
}