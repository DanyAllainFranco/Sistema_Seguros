using SegurosFYP.DataAccess.Repository;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.BusinessLogic.Services
{
    public class SalesServices
    {
        private readonly PolizaRepository _polizaRepository;

        public SalesServices(PolizaRepository polizaRepository)
        {
            _polizaRepository = polizaRepository;
        }

        #region Poliza
        public ServiceResult CargarCliente(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.CargarCliente(Poliz_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult CargarConyugue(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.CargarConyugue(Poliz_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult CargarDependientes(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.CargarDependientes(Poliz_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult CargarTipoPlan(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.CargarTipoPlan(Poliz_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult CargarEmpleado(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.CargarEmpleado(Poliz_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult Details(int Poliz_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.Details(Poliz_Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult ListPoliz()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertPoliz(tbPolizas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.Insert(item);
                if (lost.CodeStatus > 0)
                {
                    return result.Error(lost);
                }
                else
                {
                    return result.Ok(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult UpdatePoliz(tbPolizas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.Update(item);
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

        public ServiceResult DeletePoliz(tbPolizas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.Delete(item);
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

        public ServiceResult NumerationPoliz()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _polizaRepository.Numeration();
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
