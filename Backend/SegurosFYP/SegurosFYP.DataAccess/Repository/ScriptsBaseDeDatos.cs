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
        public static string Usuar_Insertar = "Acces.SP_Usuarios_Insertar";
        #endregion

        #region
        public static string Depar_Insertar = "Gral.SP_Departamentos_Insertar";
        public static string Depar_Listar = "Gral.SP_Departamentos_Listar";

        #endregion
    }
}
