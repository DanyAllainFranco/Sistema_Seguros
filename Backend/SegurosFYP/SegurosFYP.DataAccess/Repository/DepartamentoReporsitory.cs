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
    public class DepartamentoRepository : IRepository<tbDepartamentos>
    {
        public RequestStatus Delete(tbDepartamentos item)
        {
            throw new NotImplementedException();
        }

        public tbDepartamentos Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbDepartamentos find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbDepartamentos item)
        {
            string sql = ScriptsBaseDeDatos.Depar_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Depar_Id", item.Depar_Id);
                parameter.Add("@Depar_Descripcion", item.Depar_Descripcion);
                parameter.Add("@Depar_UsuarioCreacion", item.Depar_UsuarioCreacion);
                parameter.Add("@Depar_FechaCreacion", item.Depar_FechaCreacion);
                parameter.Add("@Depar_Estado", item.Depar_Estado);

                var result = db.QueryFirst(sql, parameter, commandType: CommandType.Text);

                return result;
            }
        }

        public IEnumerable<tbDepartamentos> List()
        {
            string sql = ScriptsBaseDeDatos.Depar_Listar;

            List<tbDepartamentos> result = new List<tbDepartamentos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbDepartamentos>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbDepartamentos item)
        {
            throw new NotImplementedException();
        }
    }
}
