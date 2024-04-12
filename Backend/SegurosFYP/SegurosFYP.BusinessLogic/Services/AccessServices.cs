using SegurosFYP.DataAccess.Repository;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.BusinessLogic.Services
{
    public class AccessServices
    {
        private readonly UsuarioRepository _UsuarioRepository;
        private readonly RolesRepository _rolesRepository;
        private readonly PantallaRepository _pantallaRepository;
        public AccessServices(UsuarioRepository UsuarioRepository, RolesRepository rolesRepository ,PantallaRepository pantallaRepository)
        {
            _UsuarioRepository = UsuarioRepository;
            _rolesRepository = rolesRepository;
            _pantallaRepository = pantallaRepository;
        }

        #region Usuario
        public ServiceResult ListUsu()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertUsu(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.Insert(item);
                if(lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult Login(string Usuario, string Contra)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.Login(Usuario, Contra);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult UpdateUsuario(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.Update(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult RestablecerContra(tbUsuarios item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.ReestablecerContra(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DeleteUsuario(int Usuar_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.Delete(Usuar_Id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult CargarUsuario(int Usuar_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _UsuarioRepository.find(Usuar_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion

        #region roles
        public ServiceResult ListRol()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ListPantalla()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _pantallaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.Insert(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ActualizarRol(tbRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.Update(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult InsertarPantallasPorRol(tbPantallasPorRoles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.InsertPantallasRoles(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ObtenerId(string Rol, int usuario_creacion, DateTime fecha_creacion)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.findObtenerId(Rol, usuario_creacion, fecha_creacion);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult ObtenerRol(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.ObtenerRol(Rol_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public IEnumerable<tbPantallasPorRoles> ObtenerPantallasPorRol(int id)
        {
            try
            {

                return _rolesRepository.BuscarPantallasPorRol(id);
            }
            catch (Exception ex)
            {

                return Enumerable.Empty<tbPantallasPorRoles>();
            }
        }

        public ServiceResult EliminarPantallaPorRol(int PaRo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.EliminarPantallaPorRol(PaRo_Id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult EliminarRol(int Rol_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _rolesRepository.EliminarRol(Rol_Id);
                if (lost.CodeStatus > 0)
                {
                    return result.Ok(lost);
                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion
    }
}
