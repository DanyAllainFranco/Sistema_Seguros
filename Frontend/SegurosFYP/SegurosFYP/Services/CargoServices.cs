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
    public class CargosServices
    {
        private readonly API _api;

        public CargosServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CargosViewModel>, IEnumerable<CargosViewModel>>(req =>
                {
                    req.Path = $"/api/Cargo/List/Cargo";
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

        public async Task<ServiceResult> Insert(CargosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<CargosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Cargo/Insert/Cargo";
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
        public async Task<ServiceResult> Update(CargosViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<CargosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Cargo/Update/Cargo";
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
        public async Task<ServiceResult> Delete(int Cargo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<CargosViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Cargo/Delete/Cargo?Cargo_Id={Cargo_Id}";
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
                var response = await _api.Get<IEnumerable<CargosViewModel>, IEnumerable<CargosViewModel>>(req =>
                {
                    req.Path = $"/api/Cargo/Cargar/Cargo";
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

        public async Task<ServiceResult> Details(int Cargo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<CargosViewModel>, IEnumerable<CargosViewModel>>(req =>
                {
                    req.Path = $"/api/Cargo/Detalles/Cargo?Cargo_Id={Cargo_Id}";
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