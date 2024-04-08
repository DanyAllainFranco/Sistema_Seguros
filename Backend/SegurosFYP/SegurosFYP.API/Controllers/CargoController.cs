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
    public class CargoController : ControllerBase
    {
        private readonly   InsuranceServices _insuranceServices;
        private readonly IMapper _mapper;

        public CargoController(InsuranceServices  insuranceServices, IMapper mapper)
        {
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }

        [HttpGet("List/Cargo")]
        public IActionResult ListCargo()
        {
            var list = _insuranceServices.ListCargo();
            return Ok(list);
        }

        [HttpPost("Insert/Cargo")]
        public IActionResult InsertCargo(CargosViewModel item)
        {
            var model = _mapper.Map<tbCargos>(item);
            var modelo = new tbCargos()
            {
                Cargo_Id = item.Cargo_Id,
                Cargo_Descripcion = item.Cargo_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _insuranceServices.InsertCargo(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Cargo")]
        public IActionResult UpdateCargo(CargosViewModel item)
        {
            var model = _mapper.Map<tbCargos>(item);
            var modelo = new tbCargos()
            {
                Cargo_Id = item.Cargo_Id,
                Cargo_Descripcion = item.Cargo_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _insuranceServices.UpdateCargo(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Cargo")]
        public IActionResult DeleteCargo(int Cargo_Id)
        {
            var list = _insuranceServices.DeleteCargo(Cargo_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Cargo")]
        public IActionResult CargarCargo(int Cargo_Id)
        {
            var list = _insuranceServices.CargarCargo(Cargo_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Cargo")]
        public IActionResult DetallesCargo(int Cargo_Id)
        {
            var list = _insuranceServices.DetallesCargo(Cargo_Id);

            return Ok(list);
        }

    }
}