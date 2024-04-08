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
    public class UnidadController : ControllerBase
    {
        private readonly InsuranceServices _insuranceServices;
        private readonly IMapper _mapper;

        public UnidadController(InsuranceServices insuranceServices, IMapper mapper)
        {
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }

        [HttpGet("List/Unidades")]
        public IActionResult ListUnidades()
        {
            var list = _insuranceServices.ListUnidades();
            return Ok(list);
        }

        [HttpPost("Insert/Unidades")]
        public IActionResult InsertUnidades(UnidadViewModel item)
        {
            var model = _mapper.Map<tbUnidades>(item);
            var modelo = new tbUnidades()
            {
                Unida_Id = item.Unida_Id,
                Unida_Descripcion = item.Unida_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _insuranceServices.InsertUnidades(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Unidades")]
        public IActionResult UpdateUnidades(UnidadViewModel item)
        {
            var model = _mapper.Map<tbUnidades>(item);
            var modelo = new tbUnidades()
            {
                Unida_Id = item.Unida_Id,
                Unida_Descripcion = item.Unida_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _insuranceServices.UpdateUnidades(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Unidades")]
        public IActionResult DeleteUnidades(int Unida_Id)
        {
            var list = _insuranceServices.DeleteUnidades(Unida_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Unidades")]
        public IActionResult CargarUnidades(int Unida_Id)
        {
            var list = _insuranceServices.CargarUnidades(Unida_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Unidades")]
        public IActionResult DetallesUnidades(int Unida_Id)
        {
            var list = _insuranceServices.DetallesUnidades(Unida_Id);

            return Ok(list);
        }

    }
}