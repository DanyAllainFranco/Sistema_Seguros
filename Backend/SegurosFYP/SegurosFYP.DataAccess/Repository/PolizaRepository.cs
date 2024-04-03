using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.DataAccess.Repository
{
    public class PolizaRepository : IRepository<tbPolizas>
    {
        public RequestStatus Delete(tbPolizas item)
        {
            throw new NotImplementedException();
        }

        public tbPolizas Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbPolizas find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPolizas item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPolizas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbPolizas item)
        {
            //string sql = ScriptsBaseDeDatos.Ident_Modificar;

            //using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            //{
            //    var parameter = new DynamicParameters();
            //    parameter.Add("@Tiden_Id", item.Tiden_Id);
            //    parameter.Add("@Ident_NumeroIdentificacion", item.Ident_NumeroIdentificacion);
            //    parameter.Add("@Ident_FechaNacimiento", item.Ident_FechaNacimiento);
            //    parameter.Add("@Ident_LugarNacimiento", item.Ident_LugarNacimiento);

            //    parameter.Add("@Ident_UsuarioModificacion", item.Ident_UsuarioModificacion);
            //    parameter.Add("@Ident_FechaModificacion", item.Ident_FechaModificacion);

            //    var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

            //    return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            //}
            throw new NotImplementedException();
        }
    }
}
