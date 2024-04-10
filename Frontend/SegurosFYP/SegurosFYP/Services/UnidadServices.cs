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
    public class UnidadServices
    {
        private readonly API _api;

        public UnidadServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UnidadViewModel>, IEnumerable<UnidadViewModel>>(req =>
                {
                    req.Path = $"/api/Unidad/List/Unidades";
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

        public async Task<ServiceResult> Insert(UnidadViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<UnidadViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Unidad/Insert/Unidades";
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
        public async Task<ServiceResult> Update(UnidadViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<UnidadViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Unidad/Update/Unidades";
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
        public async Task<ServiceResult> Delete(int Unida_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<UnidadViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Unidad/Delete/Unidades?Unida_Id={Unida_Id}";
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
                var response = await _api.Get<IEnumerable<UnidadViewModel>, IEnumerable<UnidadViewModel>>(req =>
                {
                    req.Path = $"/api/Unidad/Cargar/Unidades";
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

        public async Task<ServiceResult> Details(int Unida_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<UnidadViewModel>, IEnumerable<UnidadViewModel>>(req =>
                {
                    req.Path = $"/api/Unidad/Cargar/Unidades?Unida_Id={Unida_Id}";
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