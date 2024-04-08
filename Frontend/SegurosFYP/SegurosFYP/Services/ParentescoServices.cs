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
    public class ParentescoServices
    {
        private readonly API _api;

        public ParentescoServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<ParentescoViewModel>, IEnumerable<ParentescoViewModel>>(req =>
                {
                    req.Path = $"/api/Parentesco/List/Parentesco";
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

        public async Task<ServiceResult> Insert(ParentescoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<ParentescoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Parentesco/Insert/Parentesco";
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
        public async Task<ServiceResult> Update(ParentescoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<ParentescoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Parentesco/Update/Parentesco";
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
        public async Task<ServiceResult> Delete(int Paren_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<ParentescoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Parentesco/Delete/Parentesco?Paren_Id={Paren_Id}";
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
                var response = await _api.Get<IEnumerable<ParentescoViewModel>, IEnumerable<ParentescoViewModel>>(req =>
                {
                    req.Path = $"/api/Parentesco/Cargar/Parentesco";
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

        public async Task<ServiceResult> Details(int Paren_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<ParentescoViewModel>, IEnumerable<ParentescoViewModel>>(req =>
                {
                    req.Path = $"/api/Parentesco/Detalles/Parentesco?Paren_Id={Paren_Id}";
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