﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbInformacionMedica
    {
        public int Perso_Id { get; set; }
        public decimal Inmed_PesoKgs { get; set; }
        public decimal Inmed_EstaturaMtrs { get; set; }
        public string Inmed_TipoSangre { get; set; }
        public int Inmed_ReaccionesAlergicas { get; set; }
        public bool Inmed_AumentoDisminucion { get; set; }
        public decimal Inmed_AumentoDisminucionPeso { get; set; }
        public bool Inmed_IngiereBebidasAlcoholicas { get; set; }
        public int Inmed_TipoAlcohol { get; set; }
        public int Inmed_IngiereCantidad { get; set; }
        public int Inmed_IngiereFrecuencia { get; set; }
        public bool Inmed_DrogasEstimulantes { get; set; }
        public int Inmed_TipoDrogasEstimulantes { get; set; }
        public int Inmed_DrogasEstimulantesCantidad { get; set; }
        public int Inmed_DrogasEstimulantesFrecuencia { get; set; }
        public bool Inmed_Fumar { get; set; }
        public int Inmed_TipoFumar { get; set; }
        public int Inmed_FumarCantidad { get; set; }
        public int Inmed_FumarFrecuencia { get; set; }
        public bool Inmed_Enfermedad1 { get; set; }
        public bool Inmed_Enfermedad2 { get; set; }
        public bool Inmed_Enfermedad3 { get; set; }
        public bool Inmed_Enfermedad4 { get; set; }
        public bool Inmed_Enfermedad5 { get; set; }
        public bool Inmed_Enfermedad6 { get; set; }
        public bool Inmed_Enfermedad7 { get; set; }
        public bool Inmed_Enfermedad8 { get; set; }
        public bool Inmed_Enfermedad9 { get; set; }
        public int Inmed_UsuarioCreacion { get; set; }
        public DateTime Inmed_FechaCreacion { get; set; }
        public int? Inmed_UsuarioModificacion { get; set; }
        public DateTime? Inmed_FechaModificacion { get; set; }
        public bool? Inmed_Estado { get; set; }

        public virtual tbFrecuencias Inmed_DrogasEstimulantesFrecuenciaNavigation { get; set; }
        public virtual tbFrecuencias Inmed_FumarFrecuenciaNavigation { get; set; }
        public virtual tbFrecuencias Inmed_IngiereFrecuenciaNavigation { get; set; }
        public virtual tbTipoArticuloMedico Inmed_TipoAlcoholNavigation { get; set; }
        public virtual tbTipoArticuloMedico Inmed_TipoDrogasEstimulantesNavigation { get; set; }
        public virtual tbTipoArticuloMedico Inmed_TipoFumarNavigation { get; set; }
        public virtual tbUsuarios Inmed_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Inmed_UsuarioModificacionNavigation { get; set; }
        public virtual tbPersonas Perso { get; set; }
    }
}