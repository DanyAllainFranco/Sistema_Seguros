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
        private readonly EstadoCivilRepository _estadoCivilRepository;
        private readonly PersonaRepository _personaRepository;
        private readonly IdentificacionRepository _identificacionRepository;
        private readonly InformacionMedicaRepository _informacionMedicaRepository;
        public GeneralServices(DepartamentoRepository departamentoRepository ,EstadoCivilRepository estadoCivilRepository , PersonaRepository personaRepository,IdentificacionRepository identificacionRepository , InformacionMedicaRepository informacionMedicaRepository)
        {
            _departamentoRepository = departamentoRepository;
            _estadoCivilRepository = estadoCivilRepository;
            _personaRepository = personaRepository;
            _identificacionRepository = identificacionRepository;
            _informacionMedicaRepository = informacionMedicaRepository;

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

        #region EstadoCivil
        public ServiceResult ListEstadoC()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadoCivilRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertEstadoC(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadoCivilRepository.Insert(item);
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

        public ServiceResult UpdateEstadoC(tbEstadosCiviles item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadoCivilRepository.Update(item);
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

        public ServiceResult DeleteEstadoC(int Estad_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadoCivilRepository.Delete(Estad_Id);
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

        public ServiceResult CargarEstadoC (int Estad_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadoCivilRepository.find(Estad_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesEstadoC(int Estad_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _estadoCivilRepository.Details(Estad_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #region Identificacion
        public ServiceResult ListIdent()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertIdent(tbIdentificaciones item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.Insert(item);
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

        public ServiceResult UpdateIdent(tbIdentificaciones item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.Update(item);
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

        public ServiceResult DeleteIdent(tbIdentificaciones item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.Delete(item);
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

        #region Persona
        public ServiceResult ListPerso()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _personaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertPerso(tbPersonas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _personaRepository.Insert(item);
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

        public ServiceResult UpdatePerso(tbPersonas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _personaRepository.Update(item);
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

        public ServiceResult DeletePerso(tbPersonas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _personaRepository.Delete(item);
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

        #region InformacionMedica
        public ServiceResult ListInmed()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _informacionMedicaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertInmed(tbInformacionMedica item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _informacionMedicaRepository.Insert(item);
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

        public ServiceResult UpdateInmed(tbInformacionMedica item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _informacionMedicaRepository.Update(item);
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

        public ServiceResult DeleteInmed(tbInformacionMedica item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _informacionMedicaRepository.Delete(item);
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
        #endregion
    }

}
