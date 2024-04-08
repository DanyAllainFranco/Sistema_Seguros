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
    public class ParentescoRepository : IRepository<tbParentescos>
    {
        public RequestStatus Delete(int Paren_Id)
        {
            string sql = ScriptsBaseDeDatos.Parentescos_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Paren_Id", Paren_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbParentescos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbParentescos> Details(int? Paren_Id)
        {
            string sql = ScriptsBaseDeDatos.Parentescos_Cargar;

            List<tbParentescos> result = new List<tbParentescos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Paren_Id };
                result = db.Query<tbParentescos>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbParentescos> find(int Paren_Id)
        {
            string sql = ScriptsBaseDeDatos.Parentescos_Cargar;

            List<tbParentescos> result = new List<tbParentescos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Paren_Id };
                result = db.Query<tbParentescos>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbParentescos find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbParentescos item)
        {
            string sql = ScriptsBaseDeDatos.Parentescos_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Paren_Descripcion", item.Paren_Descripcion);
                parameter.Add("@Paren_UsuarioCreacion", 1);
                parameter.Add("@Paren_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbParentescos> List()
        {
            string sql = ScriptsBaseDeDatos.Parentescos_Listar;

            List<tbParentescos> result = new List<tbParentescos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbParentescos>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbParentescos item)
        {
            string sql = ScriptsBaseDeDatos.Parentescos_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Paren_Id", item.Paren_Id);
                parameter.Add("@Paren_Descripcion", item.Paren_Descripcion);
                parameter.Add("@Paren_UsuarioCreacion", 1);
                parameter.Add("@Paren_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbParentescos IRepository<tbParentescos>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
