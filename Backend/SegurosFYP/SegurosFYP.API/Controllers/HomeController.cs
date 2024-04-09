using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegurosFYP.BusinessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.API.Controllers
{
    [Route("/API/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly AccessServices _accesoServices;
        private readonly IMapper _imapper;

        public HomeController(AccessServices accesoServices, IMapper mapper)
        {
            _accesoServices = accesoServices;
            _imapper = mapper;
        }

        [HttpGet("LoginHome")]
        public IActionResult Login(string Usuario, string Contra)
        {

            var list = _accesoServices.Login(Usuario, Contra);

            return Ok(list);
        }
    }
}
