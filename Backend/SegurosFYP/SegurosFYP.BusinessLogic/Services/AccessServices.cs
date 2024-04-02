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
        //private readonly RolRepository _RolRepository;
        //private readonly PantallaRepository _pantallaRepository;
        public AccessServices(UsuarioRepository UsuarioRepository/*, RolRepository RolRepository, PantallaRepository pantallaRepository*/)
        {
            _UsuarioRepository = UsuarioRepository;
            ////_RolRepository = RolRepository;
            ////_pantallaRepository = pantallaRepository;
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
        #endregion
    }
}
