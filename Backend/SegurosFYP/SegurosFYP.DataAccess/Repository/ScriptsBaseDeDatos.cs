using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.DataAccess.Repository
{
    public class ScriptsBaseDeDatos
    {
        #region Usuario
        public static string Usuar_Insertar = "Acces.SP_Usuario_Insertar";
        #endregion

        #region Departamentos
        public static string Depar_Insertar = "Gral.SP_Departamentos_Insertar";
        public static string Depar_Listar = "Gral.SP_Departamentos_Listar";
        public static string Depar_Actualizar = "Gral.SP_Departamentos_Actualizar";
        public static string Depar_Delete = "Gral.SP_Departamentos_Eliminar";
        #endregion
    }
}
