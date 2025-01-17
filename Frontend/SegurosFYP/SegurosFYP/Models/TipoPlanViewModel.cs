﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.Common.Models
{
    public class TipoPlanViewModel
    {
        public int Tipos_Id { get; set; }
        public string Tipos_Descripcion { get; set; }
        public decimal Tipos_Deducible { get; set; }
        public decimal Tipos_MaximoVitalicio { get; set; }
        public decimal Tipos_SeguroVidaRenovableAnualMasDID { get; set; }
        public bool Tipos_DID { get; set; }
        public decimal Tipos_AsistenciaFuneraria { get; set; }
        public decimal Tipos_GastosRepatriacion { get; set; }
        public decimal Tipos_GastosFunebresTitular { get; set; }
        public decimal Tipos_GastosFunebresDependientes { get; set; }
        public decimal Tipos_GastosHogar6rentasmensuales { get; set; }
        public int Tipos_EdadMaxIngresoTitularConyuge { get; set; }
        public int Tipos_EdadMaxIngresoHijos { get; set; }
        public int Tipos_EdadMaxPermanenciaTitularConyuge { get; set; }
        public int Tipos_EdadMaxPermanenciaHijos { get; set; }
        public decimal Tipos_ReduccionMaximoVitalicio { get; set; }
        public decimal Tipos_CuartoAlimentacionDentroCA { get; set; }
        public decimal Tipos_CuartoAlimentacionFueraCA { get; set; }
        public decimal Tipos_LímiteCuartoIntensivoFueraCA { get; set; }
        public decimal Tipos_LimiteConsultaExternaMedicoGeneral { get; set; }
        public decimal Tipos_LimiteConsultaExternaMedicoEspecialista { get; set; }
        public decimal Tipos_LimiteConsultaExternaNeurologoCardiologo { get; set; }
        public decimal Tipos_CoberturaPorSidaMaximoVitalicio { get; set; }
        public int Tipos_ControlNinoSano { get; set; }
        public decimal Tipos_CentroAmerica { get; set; }
        public decimal Tipos_FueraCentroAmerica { get; set; }
        public decimal Tipos_AmbulanciaAerea { get; set; }
        public int Tipos_PeriodoEsperaEnfermedadesEspecificas { get; set; }
        public int Tipos_PeriodoEsperaEnfermedadesGraves { get; set; }
        public int Tipos_PeriodoEsperaSIDA { get; set; }
        public decimal Tipos_LimitesMomentoPartoNormal { get; set; }
        public decimal Tipos_LimitesMomentoCesarea { get; set; }
        public decimal Tipos_LimitesMomentoAbortoLegal { get; set; }
        public decimal Tipos_LimitesMomentoSalaCuna { get; set; }
        public decimal Tipos_LimitesMomentoCuidadoCriticoNeonatal { get; set; }
        public decimal Tipos_LimitesMomentoGastosPsiquiatriaConsulaMedicamento { get; set; }
        public int Tipos_PeriodoEsperaCoberturaMaternidad { get; set; }
        public int Tipos_PeriodoDePreexistencia { get; set; }
        public int Tipos_PeriodoDeCarencia { get; set; }
        public int Tipos_ControlesPreventivosGinecologoANUAL { get; set; }
        public int Tipos_ControlesPreventivosProstagicoANUAL { get; set; }
        public int Tipos_ControlesPreventivosMamografiaANUAL { get; set; }
        public int Cober_Id { get; set; }

        [NotMapped]
        public string Cober_Descripcion { get; set; }

        public int Tipos_UsuarioCreacion { get; set; }
        public DateTime Tipos_FechaCreacion { get; set; }
        public int? Tipos_UsuarioModificacion { get; set; }
        public DateTime? Tipos_FechaModificacion { get; set; }
        public bool? Tipos_Estado { get; set; }
    }
}
