using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Common.Models;
using SegurosFYP.Entities.Entities;
using System.Collections.Generic;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly GeneralServices _generalServices;
        private readonly IMapper _mapper;

        public DepartamentoController(GeneralServices generalServices, IMapper mapper)
        {
            _generalServices = generalServices;
            _mapper = mapper;
        }

        [HttpGet("List/Departamentos")]
        public IActionResult ListDepartamentos()
        {
            var list = _generalServices.ListDepar();
            return Ok(list);
        }

        [HttpPost("Insert/Departamentos")]
        public IActionResult InsertDepartamento(DepartamentoViewModel item)
        {
            var model = _mapper.Map<tbDepartamentos>(item);
            var result = _generalServices.InsertDepar(model);
            return Ok(result);
        }
    }
}
