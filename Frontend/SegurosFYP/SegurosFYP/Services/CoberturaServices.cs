using SegurosFYP.Common.Models;
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
    public class CoberturaServices
    {
        private readonly API _api;

        public CoberturaServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CoberturaViewModel>, IEnumerable<CoberturaViewModel>>(req =>
                {
                    req.Path = $"/api/Cobertura/List/Cobertura";
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

        public async Task<ServiceResult> Insert(CoberturaViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<CoberturaViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Cobertura/Insert/Cobertura";
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
        public async Task<ServiceResult> Update(CoberturaViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<CoberturaViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Cobertura/Update/Cobertura";
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
        public async Task<ServiceResult> Delete(int Cober_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<CoberturaViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Cobertura/Delete/Cobertura?Cober_Id={Cober_Id}";
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
                var response = await _api.Get<IEnumerable<CoberturaViewModel>, IEnumerable<CoberturaViewModel>>(req =>
                {
                    req.Path = $"/api/Cobertura/Cargar/Cobertura";
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

        public async Task<ServiceResult> Details(int Cober_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CoberturaViewModel>, IEnumerable<CoberturaViewModel>>(req =>
                {
                    req.Path = $"/api/Cobertura/Detalles/Cobertura?Cober_Id={Cober_Id}";
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