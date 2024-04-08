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
    public class CoberturaRepository : IRepository<tbCoberturas>
    {
        public RequestStatus Delete(int Cober_Id)
        {
            string sql = ScriptsBaseDeDatos.Coberturas_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cober_Id", Cober_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbCoberturas item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCoberturas> Details(int? Cober_Id)
        {
            string sql = ScriptsBaseDeDatos.Coberturas_Cargar;

            List<tbCoberturas> result = new List<tbCoberturas>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Cober_Id };
                result = db.Query<tbCoberturas>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbCoberturas> find(int Cober_Id)
        {
            string sql = ScriptsBaseDeDatos.Coberturas_Cargar;

            List<tbCoberturas> result = new List<tbCoberturas>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Cober_Id };
                result = db.Query<tbCoberturas>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbCoberturas find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCoberturas item)
        {
            string sql = ScriptsBaseDeDatos.Coberturas_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cober_Descripcion", item.Cober_Descripcion);
                parameter.Add("@Cober_UsuarioCreacion", 1);
                parameter.Add("@Cober_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbCoberturas> List()
        {
            string sql = ScriptsBaseDeDatos.Coberturas_Listar;

            List<tbCoberturas> result = new List<tbCoberturas>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbCoberturas>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbCoberturas item)
        {
            string sql = ScriptsBaseDeDatos.Coberturas_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cober_Id", item.Cober_Id);
                parameter.Add("@Cober_Descripcion", item.Cober_Descripcion);
                parameter.Add("@Cober_UsuarioCreacion", 1);
                parameter.Add("@Cober_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbCoberturas IRepository<tbCoberturas>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
