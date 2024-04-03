using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    public class DepartamentoController : Controller
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public DepartamentoController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }
        [HttpGet("List/Departamentos")]
        public IActionResult Index()
        {
            var list = _generalServices.ListDepar();
            return Ok(list);
        }

        [HttpPost("Insert/Departamentos")]
        public IActionResult Insert(DepartamentoViewModel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var modelo = new tbDepartamentos()
            {
                Depar_Id  = item.Depar_Id,
                Depar_Descripcion = item.Depar_Descripcion,
                Depar_UsuarioCreacion = item.Depar_UsuarioCreacion,
                Depar_FechaCreacion = item.Depar_FechaCreacion
            };
            var list = _generalServices.InsertDepar(modelo);
            return Ok(list);
        }
    }
}
