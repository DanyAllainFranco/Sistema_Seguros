using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    public class TipoPlanController : Controller
    {
        private readonly InsuranceServices _insuranceServices;
        private readonly IMapper _mapper;

        public TipoPlanController(InsuranceServices insuranceServices, IMapper mapper)
        {
            _insuranceServices = insuranceServices;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("DropDownList/TipoPlan")]
        public IActionResult DropDownList()
        {
            var list = _insuranceServices.DropDownListEmple();

            return Ok(list);
        }
    }
}
