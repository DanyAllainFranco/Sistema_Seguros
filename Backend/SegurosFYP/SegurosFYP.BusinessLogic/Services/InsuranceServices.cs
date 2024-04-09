using SegurosFYP.DataAccess.Repository;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.BusinessLogic.Services
{
    public class InsuranceServices
    {

        private readonly CargoRepository _cargoRepository;
        private readonly CausaAtencionMedicaRepository _causaAtencionMedicaRepository;
        private readonly CoberturaRepository _coberturaRepository;
        private readonly EmpleadoRepository _empleadoRepository;
        private readonly UnidadRepository _unidadRepository;
        public InsuranceServices( UnidadRepository unidadRepository,EmpleadoRepository empleadoRepository,CoberturaRepository coberturaRepository,CargoRepository cargoRepository , CausaAtencionMedicaRepository causaAtencionMedicaRepository)
        {
            _cargoRepository = cargoRepository;
            _causaAtencionMedicaRepository = causaAtencionMedicaRepository;
            _coberturaRepository = coberturaRepository;
            _empleadoRepository = empleadoRepository;
            _unidadRepository = unidadRepository;
        }
        
        #region Cargo
        public ServiceResult ListCargo()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargoRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargoRepository.Insert(item);
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

        public ServiceResult UpdateCargo(tbCargos item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargoRepository.Update(item);
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

        public ServiceResult DeleteCargo(int Cargo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargoRepository.Delete(Cargo_Id);
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

        public ServiceResult CargarCargo(int Cargo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargoRepository.find(Cargo_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesCargo(int Cargo_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _cargoRepository.Details(Cargo_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion


        #region Cobertura
        public ServiceResult ListCobertura()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _coberturaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertCobertura(tbCoberturas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _coberturaRepository.Insert(item);
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

        public ServiceResult UpdateCobertura(tbCoberturas item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _coberturaRepository.Update(item);
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

        public ServiceResult DeleteCobertura(int Cober_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _coberturaRepository.Delete(Cober_Id);
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

        public ServiceResult CargarCobertura(int Cober_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _coberturaRepository.find(Cober_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesCobertura(int Cober_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _coberturaRepository.Details(Cober_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Empleados
        public ServiceResult ListEmpleados()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadoRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertEmpleados(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadoRepository.Insert(item);
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

        public ServiceResult UpdateEmpleados(tbEmpleados item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadoRepository.Update(item);
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

        public ServiceResult DeleteEmpleados(int Emple_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadoRepository.Delete(Emple_Id);
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

        public ServiceResult CargarEmpleados(int Emple_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadoRepository.find(Emple_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesEmpleados(int Emple_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _empleadoRepository.Details(Emple_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region CausaAtencionMedica
        public ServiceResult ListCausaAtencionMedica()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _causaAtencionMedicaRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertCausaAtencionMedica(tbCausaAtencionMedica item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _causaAtencionMedicaRepository.Insert(item);
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

        public ServiceResult UpdateCausaAtencionMedica(tbCausaAtencionMedica item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _causaAtencionMedicaRepository.Update(item);
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

        public ServiceResult DeleteCausaAtencionMedica(int Cadme_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _causaAtencionMedicaRepository.Delete(Cadme_Id);
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

        public ServiceResult CargarCausaAtencionMedica(int Cadme_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _causaAtencionMedicaRepository.find(Cadme_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesCausaAtencionMedica(int Cadme_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _causaAtencionMedicaRepository.Details(Cadme_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion

        #region Unidades
        public ServiceResult ListUnidades()
        {
            var result = new ServiceResult();
            try
            {
                var lost = _unidadRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServiceResult InsertUnidades(tbUnidades item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _unidadRepository.Insert(item);
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

        public ServiceResult UpdateUnidades(tbUnidades item)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _unidadRepository.Update(item);
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

        public ServiceResult DeleteUnidades(int Unida_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _unidadRepository.Delete(Unida_Id);
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

        public ServiceResult CargarUnidades(int Unida_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _unidadRepository.find(Unida_Id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServiceResult DetallesUnidades(int Unida_Id)
        {
            var result = new ServiceResult();
            try
            {
                var lost = _unidadRepository.Details(Unida_Id);

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
