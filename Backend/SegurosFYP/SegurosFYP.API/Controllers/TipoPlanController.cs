using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoPlanController : Controller
    {
        private readonly InsuranceServices _insuranceServices;
        private readonly IMapper _mapper;

        public TipoPlanController(InsuranceServices insuranceServices, IMapper mapper)
        {
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }
        [HttpGet("List/TipoPlan")]
        public IActionResult Index()
        {
            var list = _insuranceServices.ListTipo();
            return Ok(list);
        }
        [HttpGet("DropDownList/TipoPlan")]
        public IActionResult DropDownLists()
        {
            var list = _insuranceServices.DropDownListTipo();

            return Ok(list);
        }
    }
}
