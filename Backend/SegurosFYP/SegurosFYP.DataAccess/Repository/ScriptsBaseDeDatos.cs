using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.DataAccess.Repository
{
    public class ScriptsBaseDeDatos
    {
        #region Acceso

        #region Usuario
        public static string Usuar_Insertar = "Acces.SP_Usuarios_Insertar";
        public static string Usuar_Login= "Acces.SP_Usuarios_InicioSesion";

        #endregion

        #region Roles

        public static string Rol_Insertar = "[Acces].[sp_Roles_Insertar]";
        public static string Rol_Listar = "[Acces].[sp_Roles_Listar]";
        public static string Rol_Eliminar = "[Acces].[sp_Roles_Eliminar]";
        public static string Rol_Actualizar = "[Acces].[sp_Roles_Actualizar]";
        public static string Rol_Obtener = "[Acces].[sp_Roles_Obtener]";
        //public static string Rol_Llenar = "[Gene].[sp_Estados_llenar]";
        public static string Rol_ObtenerId = "Acces.sp_Roles_ObtenerID";
        #endregion

        #region PantallasPorRoles
        public static string PanRo_Insertar = "[Acces].[sp_PantallasPorRol_crear]";
        public static string PanRo_Buscar = "[Acces].[sp_PantallasPorRol_buscar]";
        public static string PanRo_Eliminar = "[Acces].[sp_PantallasPorRol_eliminar]";
        #endregion

        #region Pantallas
        public static string Panta_Listar = "[AcceS].[sp_Pantallas_listar]";
        #endregion


        #endregion

        #region General

        #region TiposIdentificaciones
        public static string TiposIdentificaciones_Insertar = "Gral.SP_TiposIdentificaciones_Insertar";
        public static string TiposIdentificaciones_Listar = "Gral.SP_TiposIdentificaciones_Listar";
        public static string TiposIdentificaciones_Cargar = "Gral.SP_TiposIdentificaciones_Cargar";
        public static string TiposIdentificaciones_Actualizar = "Gral.SP_TiposIdentificaciones_Actualizar";
        public static string TiposIdentificaciones_Delete = "Gral.SP_TiposIdentificaciones_Eliminar";
        #endregion

        #region TipoArticuloMedico
        public static string TipoArticuloMedico_Insertar = "Gral.SP_TipoArticuloMedico_Insertar";
        public static string TipoArticuloMedico_Listar = "Gral.SP_TipoArticuloMedico_Listar";
        public static string TipoArticuloMedico_Cargar = "Gral.SP_TipoArticuloMedico_Cargar";
        public static string TipoArticuloMedico_Actualizar = "Gral.SP_TipoArticuloMedico_Actualizar";
        public static string TipoArticuloMedico_Delete = "Gral.SP_TipoArticuloMedico_Eliminar";
        #endregion

        #region Enfermedad
        public static string Enfermedad_Insertar = "Gral.SP_Enfermedades_Insertar";
        public static string Enfermedad_Listar = "Gral.SP_Enfermedades_Listar";
        public static string Enfermedad_Cargar = "Gral.SP_Enfermedades_Cargar";
        public static string Enfermedad_Actualizar = "Gral.SP_Enfermedades_Actualizar";
        public static string Enfermedad_Delete = "Gral.SP_Enfermedades_Eliminar";
        #endregion


        #region Frecuencia
        public static string Frecuencia_Insertar = "Gral.SP_Frecuencias_Insertar";
        public static string Frecuencia_Listar = "Gral.SP_Frecuencias_Listar";
        public static string Frecuencia_Cargar = "Gral.SP_Frecuencias_Cargar";
        public static string Frecuencia_Actualizar = "Gral.SP_Frecuencias_Actualizar";
        public static string Frecuencia_Delete = "Gral.SP_Frecuencias_Eliminar";
        #endregion


        #region EstadoCivil
        public static string EstadoC_Insertar = "Gral.SP_EstadosCiviles_Insertar";
        public static string EstadoC_Listar = "Gral.SP_EstadosCiviles_Listar";
        public static string EstadoC_Detalles = "Gral.SP_EstadosCiviles_Detalles";
        public static string EstadoC_Cargar = "Gral.SP_EstadosCiviles_Cargar";
        public static string EstadoC_Actualizar = "Gral.SP_EstadosCiviles_Actualizar";
        public static string EstadoC_Delete = "Gral.SP_EstadosCiviles_Eliminar";

        #endregion

        #region Departamento
        public static string Depar_Insertar = "Gral.SP_Departamentos_Insertar";
        public static string Depar_Listar = "Gral.SP_Departamentos_Listar";
        public static string Depar_Cargar = "Gral.SP_Departamentos_Cargar";
        public static string Depar_Actualizar = "Gral.SP_Departamentos_Actualizar";
        public static string Depar_Delete = "Gral.SP_Departamentos_Eliminar";
        #endregion

        #region Persona
        public static string Perso_Insertar = "Gral.SP_Personas_Insertar";
        public static string Perso_Modificar = "Gral.SP_Personas_Modificar";
        public static string Perso_Eliminar = "Gral.SP_Personas_Eliminar";
        public static string Perso_Numeracion = "Gral.SP_Personas_Numeracion";

        #endregion

        #region InformacionMedica
        public static string Inmed_Insertar = "Gral.SP_InformacionMedica_Insertar";
        public static string Inmed_Modificar = "Gral.SP_InformacionMedica_Modificar";
        public static string Inmed_Eliminar = "Gral.SP_InformacionMedica_Eliminar";
        #endregion

        #region Identidad
        public static string Ident_Insertar = "Gral.SP_Identificaciones_Insertar";
        public static string Ident_Modificar = "Gral.SP_Identificaciones_Modificar";
        public static string Ident_Eliminar = "Gral.SP_Identificaciones_Eliminar";
        public static string Ident_Numeracion = "Gral.SP_Identificaciones_Numeracion";
        public static string Identificacion_Listar = "Gral.SP_Identificaciones_Listar";
        public static string Identificacion_Cargar = "Gral.SP_Identificaciones_Cargar";
        #endregion

        #region Poliza
        public static string Poliz_Insertar = "Venta.SP_Polizas_Insertar";
        public static string Poliz_Modificar = "Venta.SP_Polizas_Modificar";
        public static string Poliz_Eliminar = "Venta.SP_Polizas_Eliminar";
        public static string Poliz_Listar = "Venta.SP_Polizas_Listar";
        public static string Poliz_Numeracion = "Venta.SP_Polizas_Numeracion";
        #endregion

        #region Municipio
        public static string Municipios_Insertar = "Gral.SP_Municipios_Insertar";
        public static string Municipios_Listar = "Gral.SP_Municipios_Listar";
        public static string Municipios_Cargar = "Gral.SP_Municipios_Cargar";
        public static string Municipios_DropDownList = "Gral.SP_Municipios_DropDownList";
        public static string Municipios_Actualizar = "Gral.SP_Municipios_Actualizar";
        public static string Municipios_Delete = "Gral.SP_Municipios_Eliminar";
        #endregion

        #region Pais
        public static string Paises_Insertar = "Gral.SP_Paises_Insertar";
        public static string Paises_Listar = "Gral.SP_Paises_Listar";
        public static string Paises_Cargar = "Gral.SP_Paises_Cargar";
        public static string Paises_Actualizar = "Gral.SP_Paises_Actualizar";
        public static string Paises_Delete = "Gral.SP_Paises_Eliminar";
        #endregion

        #region Pais
        public static string Parentescos_Insertar = "Gral.SP_Parentescos_Insertar";
        public static string Parentescos_Listar = "Gral.SP_Parentescos_Listar";
        public static string Parentescos_Cargar = "Gral.SP_Parentescos_Cargar";
        public static string Parentescos_Actualizar = "Gral.SP_Parentescos_Actualizar";
        public static string Parentescos_Delete = "Gral.SP_Parentescos_Eliminar";
        #endregion
        #endregion

        #region Seguro
        #region Cargo
        public static string Cargos_Insertar = "Segur.SP_Cargos_Insertar";
        public static string Cargos_Listar = "Segur.SP_Cargos_Listar";
        public static string Cargos_Cargar = "Segur.SP_Cargos_Cargar";
        public static string Cargos_Actualizar = "Segur.SP_Cargos_Actualizar";
        public static string Cargos_Delete = "Segur.SP_Cargos_Eliminar";
        #endregion


        #region CausaAtencionMedica
        public static string CausaAtencionMedica_Insertar = "Segur.SP_CausaAtencionMedica_Insertar";
        public static string CausaAtencionMedica_Listar = "Segur.SP_CausaAtencionMedica_Listar";
        public static string CausaAtencionMedica_Cargar = "Segur.SP_CausaAtencionMedica_Cargar";
        public static string CausaAtencionMedica_Actualizar = "Segur.SP_CausaAtencionMedica_Actualizar";
        public static string CausaAtencionMedica_Delete = "Segur.SP_CausaAtencionMedica_Eliminar";
        #endregion


        #region Coberturas
        public static string Coberturas_Insertar = "Segur.SP_Coberturas_Insertar";
        public static string Coberturas_Listar = "Segur.SP_Coberturas_Listar";
        public static string Coberturas_Cargar = "Segur.SP_Coberturas_Cargar";
        public static string Coberturas_Actualizar = "Segur.SP_Coberturas_Actualizar";
        public static string Coberturas_Delete = "Segur.SP_Coberturas_Eliminar";
        #endregion

        #region Empleados
        public static string Empleados_Insertar = "Segur.SP_Empleados_Insertar";
        public static string Empleados_Listar = "Segur.SP_Empleados_Listar";
        public static string Empleados_Cargar = "Segur.SP_Empleados_Cargar";
        public static string Empleados_DropDownList = "Segur.SP_Empleados_DropDownList";
        public static string Empleados_Actualizar = "Segur.SP_Empleados_Actualizar";
        public static string Empleados_Delete = "Segur.SP_Empleados_Eliminar";
        #endregion

        #region Unidades
        public static string Unidades_Insertar = "Segur.SP_Unidades_Insertar";
        public static string Unidades_Listar = "Segur.SP_Unidades_Listar";
        public static string Unidades_Cargar = "Segur.SP_Unidades_Cargar";
        public static string Unidades_Actualizar = "Segur.SP_Unidades_Actualizar";
        public static string Unidades_Delete = "Segur.SP_Unidades_Eliminar";
        #endregion

        #region TipoPlan
        public static string TiposPlan_DropDownList = "Segur.SP_TiposPlan_DropDownList";
        public static string TiposPlan_Listar = "Segur.SP_TiposPlan_Listar";


        #endregion

        #endregion
    }
}