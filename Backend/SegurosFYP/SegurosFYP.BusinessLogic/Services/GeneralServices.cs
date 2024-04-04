using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SegurosFYP.DataAccess.Repository;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.BusinessLogic.Services
{
    public class GeneralServices
    {
        private readonly DepartamentoRepository _departamentoRepository;
      
        public GeneralServices(DepartamentoRepository departamentoRepository)
        {
            _departamentoRepository = departamentoRepository;
           
        }

        #region Departamentos
   
            public ServiceResult ListDepar()
            {
                var result = new ServiceResult();
                try
                {
                    var lost = _departamentoRepository.List();
                    return result.Ok(lost);
                }
                catch (Exception ex)
                {
                    return result.Error(ex.Message);
                }
            }
            public ServiceResult InsertDepar(tbDepartamentos item)
            {
                var result = new ServiceResult();
                try
                {
                    var lost = _departamentoRepository.Insert(item);
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

            public ServiceResult UpdateDepar(tbDepartamentos item)
            {
                var result = new ServiceResult();
                try
                {
                    var lost = _departamentoRepository.Update(item);
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

            public ServiceResult DeleteDepar(string Depar_Id)
            {
                var result = new ServiceResult();
                try
                {
                    var lost = _departamentoRepository.Delete(Depar_Id);
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

        public ServiceResult CargarDepar(string Depar_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _departamentoRepository.find(Depar_Id);

                return result.Ok(lost); 

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion
    }
}
