﻿using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.Models;
using SegurosFYP_WEB.Services;
using SegurosFYP.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace SegurosFYP.Services
{
    public class PolizaServices
    {
        private readonly API _aPI;
        private readonly HttpClient _client;
        private readonly Cliente _url;
        public PolizaServices(API aPI, HttpClient httpClient, IOptions<Cliente> url)
        {
            _aPI = aPI;
            _client = httpClient;
            _url = url.Value;
            _client.BaseAddress = new Uri(_url.Url);
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {

                var response = await _aPI.Get<IEnumerable<PolizaViewModel>, IEnumerable<PolizaViewModel>>(req =>
                {
                    req.Path = $"poliza/List";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
            
        }
        public async Task<ServiceResult> InsertCliente(ClienteViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _client.PostAsJsonAsync("poliza/InsertCliente", item);

                if (!response.IsSuccessStatusCode)
                {
                    return result.Error();
                }
                else
                {
                    return result.Ok();
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        public async Task<ServiceResult> InsertDependiente(DependienteViewModel item)
        {
            var result = new ServiceResult();
            try
            {

                var response = await _client.PostAsJsonAsync("poliza/InsertPariente", item);

                if (!response.IsSuccessStatusCode)
                {
                    return result.Error();

                }
                else
                {
                    return result.Ok();

                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        public async Task<ServiceResult> InsertPoliza(PolizaViewModel item)
        {
            var result = new ServiceResult();
            try
            {

                var response = await _client.PostAsJsonAsync("poliza/InsertPoliza", item);

                if (!response.IsSuccessStatusCode)
                {
                    return result.Error();

                }
                else
                {
                    return result.Ok();

                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
        public async Task<ServiceResult> InsertIdentificacion(IdentificacionViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _client.PostAsJsonAsync("poliza/InsertIdentificacion", item);

                if (!response.IsSuccessStatusCode)
                {
                    return result.Error();

                }
                else
                {
                    return result.Ok();

                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }

        }
    }
}