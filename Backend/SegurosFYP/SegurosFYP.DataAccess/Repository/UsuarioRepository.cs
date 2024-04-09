using Dapper;
using Microsoft.Data.SqlClient;
using SegurosFYP.BusinessLogic.Services;
using SegurosFYP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurosFYP.DataAccess.Repository
{
    public class UsuarioRepository : IRepository<tbUsuarios>
    {
        public RequestStatus Delete(tbUsuarios item)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbUsuarios item)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Usuar_Usuario", item.Usuar_Usuario);
                parameter.Add("@Usuar_Contrasena", item.Usuar_Contrasena);
                parameter.Add("@Emple_Id", item.Emple_Id);
                parameter.Add("@Roles_Id", item.Roles_Id);
                parameter.Add("@Usuar_Admin", item.Usuar_Admin);
                parameter.Add("@Usuar_UsuarioCreacion", item.Usuar_UsuarioCreacion);
                parameter.Add("@Usuar_FechaCreacion", item.Usuar_FechaCreacion);

                var result = db.Execute(sql,parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = ""};
            }
        }

        public IEnumerable<tbUsuarios> List()
        {
            const string sql = "SELECT * FROM Acces.tbUsuarios";

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbUsuarios>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbUsuarios item)
        {
            throw new NotImplementedException();
        }
    }
}
