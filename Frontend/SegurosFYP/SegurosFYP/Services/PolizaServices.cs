using Microsoft.Extensions.Options;
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
using SegurosFYP.Common.Models;

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
        public async Task<ServiceResult> ListCre()
        {
            var result = new ServiceResult();
            try
            {
                var response = new PolizaCompletaViewModel();
                var listadoTipo = await _aPI.Get<IEnumerable<TipoPlanViewModel>, IEnumerable<TipoPlanViewModel>>(req =>
                {
                    req.Path = $"tipoplan/List/TipoPlan";
                });
                if (!listadoTipo.Success)
                {
                    return result.FromApi(listadoTipo);
                }
                else
                {
                    response.TiposdePlan = listadoTipo.Data;

                    return result.Ok(response);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public async Task<ServiceResult> Details(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = new PolizaCompletaViewModel();
                var listadoTipo = await _aPI.Get<TipoPlanViewModel, TipoPlanViewModel>(req =>
                {
                    req.Path = $"poliza/CargarTipoPlan?Poliz_Id=" +Poliz_Id;
                });

                var listadoPoli = await _aPI.Get<PolizaViewModel, PolizaViewModel>(req =>
                {
                    req.Path = $"poliza/Details?Poliz_Id=" + Poliz_Id;
                });

                var listadoClie = await _aPI.Get<Cliente1ViewModel, Cliente1ViewModel>(req =>
                {
                    req.Path = $"poliza/CargarCliente?Poliz_Id=" + Poliz_Id;
                });
                var listadoDepen = await _aPI.Get<IEnumerable<DependientesViewModel>, IEnumerable<DependientesViewModel>>(req =>
                {
                    req.Path = $"poliza/CargarDependientes?Poliz_Id=" + Poliz_Id;
                });
                var listadoConyu = await _aPI.Get<ConyugueViewModel, ConyugueViewModel>(req =>
                {
                    req.Path = $"poliza/CargarConyugue?Poliz_Id=" + Poliz_Id;
                });
                var listadoEmple = await _aPI.Get<EmpleadoViewModel, EmpleadoViewModel>(req =>
                {
                    req.Path = $"poliza/CargarEmpleado?Poliz_Id=" + Poliz_Id;
                });
                if (!listadoTipo.Success)
                {
                    return result.FromApi(listadoTipo);
                }
                else
                {
                    response.TipodePlan = listadoTipo.Data;

                    response.Cliente1 = listadoClie.Data;

                    response.Dependientes = listadoDepen.Data;

                    response.Poliza = listadoPoli.Data;

                    response.Conyugue = listadoConyu.Data;

                    response.Empleado = listadoEmple.Data;

                    return result.Ok(response);
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
