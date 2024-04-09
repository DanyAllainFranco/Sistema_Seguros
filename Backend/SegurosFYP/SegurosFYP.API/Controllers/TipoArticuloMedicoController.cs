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
    public class TipoArticuloMedicoController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public TipoArticuloMedicoController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/TipoArticuloMedico")]
        public IActionResult ListTipoArticuloMedico()
        {
            var list = _generalServices.ListTipoArticuloMedico();
            return Ok(list);
        }

        [HttpPost("Insert/TipoArticuloMedico")]
        public IActionResult InsertTipoArticuloMedico(TipoArticuloMedicoViewModel item)
        {
            var model = _mapper.Map<tbTipoArticuloMedico>(item);
            var modelo = new tbTipoArticuloMedico()
            {
                Tarme_Id = item.Tarme_Id,
                Tarme_Tipo = item.Tarme_Tipo,
                Tarme_Descripcion = item.Tarme_Descripcion
                //Depar_UsuarioCreacion = 1,
                //Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertTipoArticuloMedico(modelo);
            return Ok(list);
        }

        [HttpPut("Update/TipoArticuloMedico")]
        public IActionResult UpdateTipoArticuloMedico(TipoArticuloMedicoViewModel item)
        {
            var model = _mapper.Map<tbTipoArticuloMedico>(item);
            var modelo = new tbTipoArticuloMedico()
            {
                Tarme_Id = item.Tarme_Id,
                Tarme_Tipo = item.Tarme_Tipo,
                Tarme_Descripcion = item.Tarme_Descripcion
                //Depar_UsuarioModificacion = item.Depar_UsuarioModificacion,
                //Depar_FechaModificacion = item.Depar_FechaModificacion
            };
            var list = _generalServices.UpdateTipoArticuloMedico(modelo);
            return Ok(list);
        }

        [HttpDelete("Delete/TipoArticuloMedico")]
        public IActionResult DeleteTipoArticuloMedico(int Tarme_Id)
        {
            var list = _generalServices.DeleteTipoArticuloMedico(Tarme_Id);
            return Ok(list);
        }

        [HttpGet("Cargar/TipoArticuloMedico")]
        public IActionResult CargarTipoArticuloMedico(int Tarme_Id)
        {
            var list = _generalServices.CargarTipoArticuloMedico(Tarme_Id);

            return Ok(list);
        }

        [HttpGet("Detalles/TipoArticuloMedico")]
        public IActionResult DetallesTipoArticuloMedico(int Tarme_Id)
        {
            var list = _generalServices.DetallesTipoArticuloMedico(Tarme_Id);

            return Ok(list);
        }

    }
}