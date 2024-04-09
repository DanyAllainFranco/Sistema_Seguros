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
    public class TipoPlanRepository : IRepository<tbTiposPlanes>
    {
        public RequestStatus Delete(tbTiposPlanes item)
        {
            throw new NotImplementedException();
        }

        public tbTiposPlanes Details(int? id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<tbTiposPlanes> DropDownList()
        {
            string sql = ScriptsBaseDeDatos.TiposPlan_DropDownList;

            List<tbTiposPlanes> result = new List<tbTiposPlanes>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbTiposPlanes>(sql, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public tbTiposPlanes find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTiposPlanes item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbTiposPlanes> List()
        {
            string sql = ScriptsBaseDeDatos.TiposPlan_Listar;

            List<tbTiposPlanes> result = new List<tbTiposPlanes>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbTiposPlanes>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbTiposPlanes item)
        {
            //string sql = ScriptsBaseDeDatos.Ident_Modificar;

            //using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            //{
            //    var parameter = new DynamicParameters();
            //    parameter.Add("@Tiden_Id", item-);
            //    parameter.Add("@Ident_NumeroIdentificacion", item.Ident_NumeroIdentificacion);
            //    parameter.Add("@Ident_FechaNacimiento", item.Ident_FechaNacimiento);
            //    parameter.Add("@Ident_LugarNacimiento", item.Ident_LugarNacimiento);

            //    parameter.Add("@Ident_UsuarioModificacion", 1 /*HttpContext.Session.GetSession("Usuar_Id")*/);
            //    parameter.Add("@Ident_FechaModificacion", DateTime.Now);

            //    var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

            //    return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            //}
            throw new NotImplementedException();
        }
    }
}
