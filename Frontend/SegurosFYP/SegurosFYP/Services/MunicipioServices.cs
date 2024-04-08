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
    public class MunicipioServices
    {
        private readonly API _api;

        public MunicipioServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipioViewModel>, IEnumerable<MunicipioViewModel>>(req =>
                {
                    req.Path = $"/api/Municipio/List/Municipio";
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

        public async Task<ServiceResult> Insert(MunicipioViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<MunicipioViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Municipio/Insert/Municipio";
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
        public async Task<ServiceResult> Update(MunicipioViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<MunicipioViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Municipio/Update/Municipio";
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
        public async Task<ServiceResult> Delete(string Munic_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<MunicipioViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Municipio/Delete/Municipio?Munic_Id={Munic_Id}";
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


        public async Task<ServiceResult> Find(string Munic_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipioViewModel>, IEnumerable<MunicipioViewModel>>(req =>
                {
                    req.Path = $"/api/Municipio/Cargar/Municipio?Munic_Id={Munic_Id}";
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

        public async Task<ServiceResult> Details(string Munic_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<MunicipioViewModel>, IEnumerable<MunicipioViewModel>>(req =>
                {
                    req.Path = $"/api/Municipio/Cargar/Municipio?Munic_Id={Munic_Id}";
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