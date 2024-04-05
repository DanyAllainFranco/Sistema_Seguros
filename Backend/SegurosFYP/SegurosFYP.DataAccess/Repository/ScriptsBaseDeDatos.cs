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
        #endregion

        #endregion

        #region General

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
        #endregion

        #region Poliza
        public static string Poliz_Insertar = "Venta.SP_Polizas_Insertar";
        public static string Poliz_Modificar = "Venta.SP_Polizas_Modificar";
        public static string Poliz_Eliminar = "Venta.SP_Polizas_Eliminar";
        public static string Poliz_Listar = "Venta.SP_Polizas_Listar";
        #endregion


        #endregion
    }
}