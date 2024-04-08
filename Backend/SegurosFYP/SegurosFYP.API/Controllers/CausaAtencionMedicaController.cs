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
    public class CausaAtencionMedicaController : ControllerBase
    {
        private readonly InsuranceServices _insuranceServices;
        private readonly IMapper _mapper;

        public CausaAtencionMedicaController(InsuranceServices insuranceServices, IMapper mapper)
        {
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }

        [HttpGet("List/CausaAtencionMedica")]
        public IActionResult ListCausaAtencionMedica()
        {
            var list = _insuranceServices.ListCausaAtencionMedica();
            return Ok(list);
        }

        [HttpPost("Insert/CausaAtencionMedica")]
        public IActionResult InsertCausaAtencionMedica(CausaAtencionMedicaViewModel item)
        {
            var model = _mapper.Map<tbCausaAtencionMedica>(item);
            var modelo = new tbCausaAtencionMedica()
            {
                Catme_Id = item.Catme_Id,
                Catme_Descripcion = item.Catme_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _insuranceServices.InsertCausaAtencionMedica(modelo);
            return Ok(list);
        }

        [HttpPut("Update/CausaAtencionMedica")]
        public IActionResult UpdateCausaAtencionMedica(CausaAtencionMedicaViewModel item)
        {
            var model = _mapper.Map<tbCausaAtencionMedica>(item);
            var modelo = new tbCausaAtencionMedica()
            {
                Catme_Id = item.Catme_Id,
                Catme_Descripcion = item.Catme_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _insuranceServices.UpdateCausaAtencionMedica(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/CausaAtencionMedica")]
        public IActionResult DeleteCausaAtencionMedica(int Catme_Id)
        {
            var list = _insuranceServices.DeleteCausaAtencionMedica(Catme_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/CausaAtencionMedica")]
        public IActionResult CargarCausaAtencionMedica(int Catme_Id)
        {
            var list = _insuranceServices.CargarCausaAtencionMedica(Catme_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/CausaAtencionMedica")]
        public IActionResult DetallesCausaAtencionMedica(int Catme_Id)
        {
            var list = _insuranceServices.DetallesCausaAtencionMedica(Catme_Id);

            return Ok(list);
        }

    }
}