﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace SegurosFYP.Entities.Entities
{
    public partial class tbUsuarios
    {
        public tbUsuarios()
        {
            InverseUsuar_UsuarioCreacionNavigation = new HashSet<tbUsuarios>();
            InverseUsuar_UsuarioModificacionNavigation = new HashSet<tbUsuarios>();
            tbCargosCargo_UsuarioCreacionNavigation = new HashSet<tbCargos>();
            tbCargosCargo_UsuarioModificacionNavigation = new HashSet<tbCargos>();
            tbCausaAtencionMedicaCatme_UsuarioCreacionNavigation = new HashSet<tbCausaAtencionMedica>();
            tbCausaAtencionMedicaCatme_UsuarioModificacionNavigation = new HashSet<tbCausaAtencionMedica>();
            tbCoberturasCober_UsuarioCreacionNavigation = new HashSet<tbCoberturas>();
            tbCoberturasCober_UsuarioModificacionNavigation = new HashSet<tbCoberturas>();
            tbDepartamentosDepar_UsuarioCreacionNavigation = new HashSet<tbDepartamentos>();
            tbDepartamentosDepar_UsuarioModificacionNavigation = new HashSet<tbDepartamentos>();
            tbDesembolsosDesem_UsuarioCreacionNavigation = new HashSet<tbDesembolsos>();
            tbDesembolsosDesem_UsuarioModificacionNavigation = new HashSet<tbDesembolsos>();
            tbEmpleadosEmple_UsuarioCreacionNavigation = new HashSet<tbEmpleados>();
            tbEmpleadosEmple_UsuarioModificacionNavigation = new HashSet<tbEmpleados>();
            tbEnfermedadesEnfer_UsuarioCreacionNavigation = new HashSet<tbEnfermedades>();
            tbEnfermedadesEnfer_UsuarioModificacionNavigation = new HashSet<tbEnfermedades>();
            tbEstadosCivilesEstad_UsuarioCreacionNavigation = new HashSet<tbEstadosCiviles>();
            tbEstadosCivilesEstad_UsuarioModificacionNavigation = new HashSet<tbEstadosCiviles>();
            tbFacturaMedicaDetalleFadet_UsuarioCreacionNavigation = new HashSet<tbFacturaMedicaDetalle>();
            tbFacturaMedicaDetalleFadet_UsuarioModificacionNavigation = new HashSet<tbFacturaMedicaDetalle>();
            tbFacturaMedicaEncabezadoFaenca_UsuarioCreacionNavigation = new HashSet<tbFacturaMedicaEncabezado>();
            tbFacturaMedicaEncabezadoFaenca_UsuarioModificacionNavigation = new HashSet<tbFacturaMedicaEncabezado>();
            tbFrecuenciasFrecu_UsuarioCreacionNavigation = new HashSet<tbFrecuencias>();
            tbFrecuenciasFrecu_UsuarioModificacionNavigation = new HashSet<tbFrecuencias>();
            tbIdentificacionesIdent_UsuarioCreacionNavigation = new HashSet<tbIdentificaciones>();
            tbIdentificacionesIdent_UsuarioModificacionNavigation = new HashSet<tbIdentificaciones>();
            tbInformacionMedicaInmed_UsuarioCreacionNavigation = new HashSet<tbInformacionMedica>();
            tbInformacionMedicaInmed_UsuarioModificacionNavigation = new HashSet<tbInformacionMedica>();
            tbInformeMedicoInfor_UsuarioCreacionNavigation = new HashSet<tbInformeMedico>();
            tbInformeMedicoInfor_UsuarioModificacionNavigation = new HashSet<tbInformeMedico>();
            tbMunicipiosMunic_UsuarioCreacionNavigation = new HashSet<tbMunicipios>();
            tbMunicipiosMunic_UsuarioModificacionNavigation = new HashSet<tbMunicipios>();
            tbPaisesPaise_UsuarioCreacionNavigation = new HashSet<tbPaises>();
            tbPaisesPaise_UsuarioModificacionNavigation = new HashSet<tbPaises>();
            tbPantallasPanta_UsuarioCreacionNavigation = new HashSet<tbPantallas>();
            tbPantallasPanta_UsuarioModificacionNavigation = new HashSet<tbPantallas>();
            tbPantallasPorRolesPapro_UsuarioCreacionNavigation = new HashSet<tbPantallasPorRoles>();
            tbPantallasPorRolesPapro_UsuarioModificacionNavigation = new HashSet<tbPantallasPorRoles>();
            tbParentescosParen_UsuarioCreacionNavigation = new HashSet<tbParentescos>();
            tbParentescosParen_UsuarioModificacionNavigation = new HashSet<tbParentescos>();
            tbPersonasPerso_UsuarioCreacionNavigation = new HashSet<tbPersonas>();
            tbPersonasPerso_UsuarioModificacionNavigation = new HashSet<tbPersonas>();
            tbPolizasPoliz_UsuarioCreacionNavigation = new HashSet<tbPolizas>();
            tbPolizasPoliz_UsuarioModificacionNavigation = new HashSet<tbPolizas>();
            tbPrescripcionesPresc_UsuarioCreacionNavigation = new HashSet<tbPrescripciones>();
            tbPrescripcionesPresc_UsuarioModificacionNavigation = new HashSet<tbPrescripciones>();
            tbQuejasQueja_UsuarioCreacionNavigation = new HashSet<tbQuejas>();
            tbQuejasQueja_UsuarioModificacionNavigation = new HashSet<tbQuejas>();
            tbRolesRoles_UsuarioCreacionNavigation = new HashSet<tbRoles>();
            tbRolesRoles_UsuarioModificacionNavigation = new HashSet<tbRoles>();
            tbTipoArticuloMedicoTarme_UsuarioCreacionNavigation = new HashSet<tbTipoArticuloMedico>();
            tbTipoArticuloMedicoTarme_UsuarioModificacionNavigation = new HashSet<tbTipoArticuloMedico>();
            tbTiposIdentificacionesTiden_UsuarioCreacionNavigation = new HashSet<tbTiposIdentificaciones>();
            tbTiposIdentificacionesTiden_UsuarioModificacionNavigation = new HashSet<tbTiposIdentificaciones>();
            tbTiposPlanesTipos_UsuarioCreacionNavigation = new HashSet<tbTiposPlanes>();
            tbTiposPlanesTipos_UsuarioModificacionNavigation = new HashSet<tbTiposPlanes>();
            tbUnidadesUnida_UsuarioCreacionNavigation = new HashSet<tbUnidades>();
            tbUnidadesUnida_UsuarioModificacionNavigation = new HashSet<tbUnidades>();
        }

        public int Usuar_Id { get; set; }
        public string Usuar_Usuario { get; set; }
        public string Usuar_Contrasena { get; set; }
        public int Emple_Id { get; set; }
        public int Roles_Id { get; set; }
        public bool Usuar_Admin { get; set; }
        public DateTime? Usuar_UltimaSesion { get; set; }
        public int Usuar_UsuarioCreacion { get; set; }
        public DateTime Usuar_FechaCreacion { get; set; }
        public int? Usuar_UsuarioModificacion { get; set; }
        public DateTime? Usuar_FechaModificacion { get; set; }
        public bool? Usuar_Estado { get; set; }

        public virtual tbEmpleados Emple { get; set; }
        public virtual tbRoles Roles { get; set; }
        public virtual tbUsuarios Usuar_UsuarioCreacionNavigation { get; set; }
        public virtual tbUsuarios Usuar_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> InverseUsuar_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbUsuarios> InverseUsuar_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosCargo_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCargos> tbCargosCargo_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCausaAtencionMedica> tbCausaAtencionMedicaCatme_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCausaAtencionMedica> tbCausaAtencionMedicaCatme_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbCoberturas> tbCoberturasCober_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbCoberturas> tbCoberturasCober_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosDepar_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDepartamentos> tbDepartamentosDepar_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbDesembolsos> tbDesembolsosDesem_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbDesembolsos> tbDesembolsosDesem_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosEmple_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEmpleados> tbEmpleadosEmple_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEnfermedades> tbEnfermedadesEnfer_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEnfermedades> tbEnfermedadesEnfer_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesEstad_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbEstadosCiviles> tbEstadosCivilesEstad_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFacturaMedicaDetalle> tbFacturaMedicaDetalleFadet_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFacturaMedicaDetalle> tbFacturaMedicaDetalleFadet_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFacturaMedicaEncabezado> tbFacturaMedicaEncabezadoFaenca_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFacturaMedicaEncabezado> tbFacturaMedicaEncabezadoFaenca_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbFrecuencias> tbFrecuenciasFrecu_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbFrecuencias> tbFrecuenciasFrecu_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbIdentificaciones> tbIdentificacionesIdent_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbIdentificaciones> tbIdentificacionesIdent_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbInformacionMedica> tbInformacionMedicaInmed_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbInformacionMedica> tbInformacionMedicaInmed_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbInformeMedico> tbInformeMedicoInfor_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbInformeMedico> tbInformeMedicoInfor_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosMunic_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbMunicipios> tbMunicipiosMunic_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPaises> tbPaisesPaise_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPaises> tbPaisesPaise_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallas> tbPantallasPanta_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPantallas> tbPantallasPanta_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRolesPapro_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPantallasPorRoles> tbPantallasPorRolesPapro_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbParentescos> tbParentescosParen_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbParentescos> tbParentescosParen_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonasPerso_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPersonas> tbPersonasPerso_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPolizas> tbPolizasPoliz_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPolizas> tbPolizasPoliz_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbPrescripciones> tbPrescripcionesPresc_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbPrescripciones> tbPrescripcionesPresc_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbQuejas> tbQuejasQueja_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbQuejas> tbQuejasQueja_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesRoles_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbRoles> tbRolesRoles_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTipoArticuloMedico> tbTipoArticuloMedicoTarme_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTipoArticuloMedico> tbTipoArticuloMedicoTarme_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTiposIdentificaciones> tbTiposIdentificacionesTiden_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTiposIdentificaciones> tbTiposIdentificacionesTiden_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbTiposPlanes> tbTiposPlanesTipos_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbTiposPlanes> tbTiposPlanesTipos_UsuarioModificacionNavigation { get; set; }
        public virtual ICollection<tbUnidades> tbUnidadesUnida_UsuarioCreacionNavigation { get; set; }
        public virtual ICollection<tbUnidades> tbUnidadesUnida_UsuarioModificacionNavigation { get; set; }
    }
}