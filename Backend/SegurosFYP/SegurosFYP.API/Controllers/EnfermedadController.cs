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
    public class EnfermedadController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public EnfermedadController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Enfermedad")]
        public IActionResult ListEnfermedad()
        {
            var list = _generalServices.ListEnfermedad();
            return Ok(list);
        }

        [HttpPost("Insert/Enfermedad")]
        public IActionResult InsertEnfermedad(EnfermadViewModel item)
        {
            var model = _mapper.Map<tbEnfermedades>(item);
            var modelo = new tbEnfermedades()
            {
                Enfer_Id = item.Enfer_Id,
                Enfer_Descripcion = item.Enfer_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertEnfermedad(modelo);
            return Ok(list);
        }

        [HttpPut("Update/Enfermedad")]
        public IActionResult UpdateEnfermedad(EnfermadViewModel item)
        {
            var model = _mapper.Map<tbEnfermedades>(item);
            var modelo = new tbEnfermedades()
            {
                Enfer_Id = item.Enfer_Id,
                Enfer_Descripcion = item.Enfer_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateEnfermedad(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/Enfermedad")]
        public IActionResult DeleteEnfermedad(int Enfer_Id)
        {
            var list = _generalServices.DeleteEnfermedad(Enfer_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/Enfermedad")]
        public IActionResult CargarEnfermedad(int Enfer_Id)
        {
            var list = _generalServices.CargarEnfermedad(Enfer_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/Enfermedad")]
        public IActionResult DetallesEnfermedad(int Enfer_Id)
        {
            var list = _generalServices.DetallesEnfermedad(Enfer_Id);

            return Ok(list);
        }

    }
}