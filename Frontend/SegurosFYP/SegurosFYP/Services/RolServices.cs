using SegurosFYP.Models;
using SegurosFYP.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SegurosFYP.Controllers;
using SegurosFYP_WEB.Services;
using SegurosFYP_WEB.Models;

namespace SegurosFYP.Services
{
    public class RolServices
    {
        private readonly API _api;

        public RolServices(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> ObtenerRolList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<RolesViewModel>, IEnumerable<RolesViewModel>>(req =>
                {
                    req.Path = $"API/Roles/ListadoRoles";
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

        public async Task<ServiceResult> CrearRoles(RolesViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<RolesViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Roles/CreatePantalla";
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
        public async Task<ServiceResult> ObtenerPantallaList()
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<PantallaViewModel>, IEnumerable<PantallaViewModel>>(req =>
                {
                    req.Path = $"API/Roles/CreatePantalla";
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

        public async Task<ServiceResult> EditarRol(int Rol_id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Get<IEnumerable<RolesViewModel>, IEnumerable<RolesViewModel>>(req =>
                {
                    req.Path = $"API/Rol/UpdateRol?Rol_id={Rol_id}";
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    // Aquí deberías devolver directamente el objeto DepartamentoViewModel
                    return result.Ok(response.Data);
                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }

        public async Task<ServiceResult> EliminarRol(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Delete<DepartamentoViewModel, ServiceResult>(req =>
                {
                    req.Path = $"API/Roles/DeleteRol?Rol_Id={Rol_Id}";
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
