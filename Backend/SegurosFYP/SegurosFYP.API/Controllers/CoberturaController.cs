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
    public class CoberturaController : ControllerBase
    {
        private readonly InsuranceServices _insuranceServices;
        private readonly IMapper _mapper;

        public CoberturaController(InsuranceServices insuranceServices, IMapper mapper)
        {
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }

        [HttpGet("List/Cobertura")]
        public IActionResult ListCobertura()
        {
            var list = _insuranceServices.ListCobertura();
            return Ok(list);
        }

        [HttpPost("Insert/Cobertura")]
        public IActionResult InsertCobertura(CoberturaViewModel item)
        {
            var model = _mapper.Map<tbCoberturas>(item);
            var modelo = new tbCoberturas()
            {
                Cober_Id = item.Cober_Id,
                Cober_Descripcion = item.Cober_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _insuranceServices.InsertCobertura(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Cobertura")]
        public IActionResult UpdateCobertura(CoberturaViewModel item)
        {
            var model = _mapper.Map<tbCoberturas>(item);
            var modelo = new tbCoberturas()
            {
                Cober_Id = item.Cober_Id,
                Cober_Descripcion = item.Cober_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _insuranceServices.UpdateCobertura(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Cobertura")]
        public IActionResult DeleteCobertura(int Cober_Id)
        {
            var list = _insuranceServices.DeleteCobertura(Cober_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Cobertura")]
        public IActionResult CargarCobertura(int Cober_Id)
        {
            var list = _insuranceServices.CargarCobertura(Cober_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Cobertura")]
        public IActionResult DetallesCobertura(int Cober_Id)
        {
            var list = _insuranceServices.DetallesCobertura(Cober_Id);

            return Ok(list);
        }
    }
}

    


