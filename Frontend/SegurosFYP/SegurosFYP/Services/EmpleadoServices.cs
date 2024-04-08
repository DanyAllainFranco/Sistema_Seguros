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
    public class EmpleadoServices
    {
        private readonly API _api;

        public EmpleadoServices(API api)
        {
            _api = api;
        }
        public async Task<ServiceResult> Index()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadoViewModel>, IEnumerable<EmpleadoViewModel>>(req =>
                {
                    req.Path = $"/api/Empleado/List/Empleados";
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

        public async Task<ServiceResult> Insert(EmpleadoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<EmpleadoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Empleado/Insert/Empleados";
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
        public async Task<ServiceResult> Update(EmpleadoViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Put<EmpleadoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Empleado/Update/Empleados";
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
        public async Task<ServiceResult> Delete(int Emple_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<EmpleadoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/api/Empleado/Delete/Empleados?Emple_Id={Emple_Id}";
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
                var response = await _api.Get<IEnumerable<EmpleadoViewModel>, IEnumerable<EmpleadoViewModel>>(req =>
                {
                    req.Path = $"/api/Empleado/Cargar/Empleados";
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

        public async Task<ServiceResult> Details(int Emple_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<EmpleadoViewModel>, IEnumerable<EmpleadoViewModel>>(req =>
                {
                    req.Path = $"/api/Empleado/Cargar/Empleados?Emple_Id={Emple_Id}";
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