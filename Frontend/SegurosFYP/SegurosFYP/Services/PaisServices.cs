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
    public class PaisServices
    {
        private readonly API _api;

        public PaisServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PaisesViewModel>, IEnumerable<PaisesViewModel>>(req =>
                {
                    req.Path = $"/api/Pais/List/Pais";
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

        public async Task<ServiceResult> Insert(PaisesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<PaisesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Pais/Insert/Pais";
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
        public async Task<ServiceResult> Update(PaisesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<PaisesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Pais/Update/Pais";
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
        public async Task<ServiceResult> Delete(int Paise_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<PaisesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Pais/Delete/Pais?Paise_Id={Paise_Id}";
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
                var response = await _api.Get<IEnumerable<PaisesViewModel>, IEnumerable<PaisesViewModel>>(req =>
                {
                    req.Path = $"/api/Pais/Cargar/Pais";
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

        public async Task<ServiceResult> Details(int Paise_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PaisesViewModel>, IEnumerable<PaisesViewModel>>(req =>
                {
                    req.Path = $"/api/Pais/Detalles/Pais?Paise_Id={Paise_Id}";
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