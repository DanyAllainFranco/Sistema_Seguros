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
        private readonly EnfermedadRepository _enfermedadRepository;
        private readonly FrecuenciaRepository _frecuenciaRepository;
        private readonly MunicipioRepository _municipioRepository;
        private readonly PaisRepository _paisRepository;
        private readonly ParentescoRepository _parentescoRepository;
        private readonly TipoArticuloMedicoRepository _tipoArticuloMedicoRepository;
        private readonly TiposIdentificacionesRepository _tiposIdentificacionesRepository;

        public GeneralServices(TiposIdentificacionesRepository tiposIdentificacionesRepository,TipoArticuloMedicoRepository tipoArticuloMedicoRepository,ParentescoRepository parentescoRepository,PaisRepository paisRepository , DepartamentoRepository departamentoRepository ,EstadoCivilRepository estadoCivilRepository , PersonaRepository personaRepository,IdentificacionRepository identificacionRepository , InformacionMedicaRepository informacionMedicaRepository , EnfermedadRepository enfermedadRepository , FrecuenciaRepository frecuenciaRepository,MunicipioRepository municipioRepository)
        {
            _departamentoRepository = departamentoRepository;
            _estadoCivilRepository = estadoCivilRepository;
            _personaRepository = personaRepository;
            _identificacionRepository = identificacionRepository;
            _informacionMedicaRepository = informacionMedicaRepository;
            _enfermedadRepository = enfermedadRepository;
            _frecuenciaRepository = frecuenciaRepository;
            _municipioRepository = municipioRepository;
            _paisRepository = paisRepository;
            _parentescoRepository = parentescoRepository;
            _tipoArticuloMedicoRepository = tipoArticuloMedicoRepository;
            _tipoArticuloMedicoRepository = tipoArticuloMedicoRepository;
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
        #endregion

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
        public List<tbIdentificaciones> NumerationIdent(int top)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.Numeration(top);
                return lost;
            }
            catch (Exception ex)
            {
                return new List<tbIdentificaciones>();
            }
        }

        public ServiceResult DeleteIdent(int Ident_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.Delete(Ident_Id);
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

        public ServiceResult CargarIdent(int Ident_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.find(Ident_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesIdent(int Ident_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _identificacionRepository.DetailsIdent(Ident_Id);

                return result.Ok(lost);

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
        public ServiceResult NumerationPerso(int top)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _personaRepository.Numeration(top);
                return result.Ok(lost);
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
        
        #region Enfermedad

        public ServiceResult ListEnfermedad()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _enfermedadRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertEnfermedad(tbEnfermedades item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _enfermedadRepository.Insert(item);
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

        public ServiceResult UpdateEnfermedad(tbEnfermedades item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _enfermedadRepository.Update(item);
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

        public ServiceResult DeleteEnfermedad(int Enfer_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _enfermedadRepository.Delete(Enfer_Id);
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

        public ServiceResult CargarEnfermedad(int Enfer_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _enfermedadRepository.find(Enfer_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesEnfermedad(int Enfer_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _enfermedadRepository.Details(Enfer_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion


        #region Frecuencia
        public ServiceResult ListFrecuencia()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _frecuenciaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertFrecuencia(tbFrecuencias item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _frecuenciaRepository.Insert(item);
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

        public ServiceResult UpdateFrecuencia(tbFrecuencias item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _frecuenciaRepository.Update(item);
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

        public ServiceResult DeleteFrecuencia(int Frecu_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _frecuenciaRepository.Delete(Frecu_Id);
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

        public ServiceResult CargarFrecuencia(int Frecu_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _frecuenciaRepository.find(Frecu_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesFrecuencia(int Frecu_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _frecuenciaRepository.Details(Frecu_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Municipio
        public ServiceResult ListMunicipio()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipioRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertMunicipio(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipioRepository.Insert(item);
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

        public ServiceResult UpdateMunicipio(tbMunicipios item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipioRepository.Update(item);
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

        public ServiceResult DeleteMunicipio(string Munic_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipioRepository.Delete(Munic_Id);
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

        public ServiceResult CargarMunicipio(string Munic_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipioRepository.find(Munic_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesMunicipio(string Munic_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _municipioRepository.Details(Munic_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Pais
        public ServiceResult ListPais()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _paisRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertPais(tbPaises item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _paisRepository.Insert(item);
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

        public ServiceResult UpdatePais(tbPaises item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _paisRepository.Update(item);
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

        public ServiceResult DeletePais(int Paise_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _paisRepository.Delete(Paise_Id);
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

        public ServiceResult CargarPais(int Paise_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _paisRepository.find(Paise_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesPais(int Paise_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _paisRepository.Details(Paise_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        #endregion

        #region Parentesco
        public ServiceResult ListParentesco()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _parentescoRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertParentesco(tbParentescos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _parentescoRepository.Insert(item);
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

        public ServiceResult UpdateParentesco(tbParentescos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _parentescoRepository.Update(item);
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

        public ServiceResult DeleteParentesco(int Paren_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _parentescoRepository.Delete(Paren_Id);
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

        public ServiceResult CargarParentesco(int Paren_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _parentescoRepository.find(Paren_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesParentesco(int Paren_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _parentescoRepository.Details(Paren_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region TipoArticuloMedico
        public ServiceResult ListTipoArticuloMedico()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tipoArticuloMedicoRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertTipoArticuloMedico(tbTipoArticuloMedico item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tipoArticuloMedicoRepository.Insert(item);
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

        public ServiceResult UpdateTipoArticuloMedico(tbTipoArticuloMedico item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tipoArticuloMedicoRepository.Update(item);
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

        public ServiceResult DeleteTipoArticuloMedico(int Tarme_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tipoArticuloMedicoRepository.Delete(Tarme_Id);
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

        public ServiceResult CargarTipoArticuloMedico(int Tarme_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tipoArticuloMedicoRepository.find(Tarme_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesTipoArticuloMedico(int Tarme_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tipoArticuloMedicoRepository.Details(Tarme_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region TiposIdentificaciones
        public ServiceResult ListTiposIdentificaciones()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tiposIdentificacionesRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertTiposIdentificaciones(tbTiposIdentificaciones item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tiposIdentificacionesRepository.Insert(item);
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

        public ServiceResult UpdateTiposIdentificaciones(tbTiposIdentificaciones item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tiposIdentificacionesRepository.Update(item);
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

        public ServiceResult DeleteTiposIdentificaciones(int Tiden_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tiposIdentificacionesRepository.Delete(Tiden_Id);
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

        public ServiceResult CargarTiposIdentificaciones(int Tiden_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tiposIdentificacionesRepository.find(Tiden_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesTiposIdentificaciones(int Tiden_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _tiposIdentificacionesRepository.Details(Tiden_Id);

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
