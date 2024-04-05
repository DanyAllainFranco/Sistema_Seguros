using SegurosFYP.Models;
using SegurosFYP.WebAPI;
using SegurosFYP_WEB.Models;
using SegurosFYP_WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SegurosFYP.Services
{
    public class EstadoCivilServices
    {
        private readonly API _api;

        public EstadoCivilServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadoCivilViewModel>, IEnumerable<EstadoCivilViewModel>>(req =>
                {
                    req.Path = $"/api/EstadoCivil/List/EstadoCivil";
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }

        public async Task<ServiceResult> Insert(EstadoCivilViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<EstadoCivilViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/EstadoCivil/Insert/EstadoCivil";
                    req.Content = item;
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
        public async Task<ServiceResult> Update(EstadoCivilViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<EstadoCivilViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/EstadoCivil/Update/EstadoCivil";
                    req.Content = item;
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }

        }
        public async Task<ServiceResult> Delete(int Estad_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<EstadoCivilViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/EstadoCivil/Delete/EstadoCivil?Estad_Id={Estad_Id}";
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }

        }


        public async Task<ServiceResult> Find()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadoCivilViewModel>, IEnumerable<EstadoCivilViewModel>>(req =>
                {
                    req.Path = $"/api/EstadoCivil/Cargar/EstadoCivil";
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }

        public async Task<ServiceResult> Details(int Estad_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EstadoCivilViewModel>, IEnumerable<EstadoCivilViewModel>>(req =>
                {
                    req.Path = $"/api/EstadoCivil/Detalles/EstadoCivil?Estad_Id={Estad_Id}";
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
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }


    }
}