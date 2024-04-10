﻿using SegurosFYP.Models;
using SegurosFYP.WebAPI;
using SegurosFYP_WEB.Models;
using SegurosFYP_WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Services
{
    public class UsuarioService
    {
        private readonly API _api;

        public UsuarioService(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> Login(string Usuario, string Contra)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UsuarioViewModel>, IEnumerable<UsuarioViewModel>>(req =>
                {
                    req.Path = $"/API/Home/LoginHome?Usuario={Usuario}&Contra={Contra}";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    // Aquí deberías devolver directamente el objeto DepartamentoViewModel
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
    }
}