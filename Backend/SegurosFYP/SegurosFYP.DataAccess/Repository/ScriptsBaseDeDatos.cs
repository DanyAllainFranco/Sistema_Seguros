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

        #region Departamento
        public static string Depar_Insertar = "Gral.SP_Departamentos_Insertar";
        public static string Depar_Listar = "Gral.SP_Departamentos_Listar";
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

        #region
        public static string Ident_Insertar = "Gral.SP_Identificaciones_Insertar";
        public static string Ident_Modificar = "Gral.SP_Identificaciones_Modificar";
        public static string Ident_Eliminar = "Gral.SP_Identificaciones_Eliminar";
        #endregion

        #endregion

        #region Seguro
        #endregion

        #region Venta
        #endregion


    }
}
