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
    public class CargoRepository : IRepository<tbCargos>
    {
        public RequestStatus Delete(int Cargo_Id)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cargo_Id", Cargo_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbCargos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCargos> Details(int? Cargo_Id)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Cargar;

            List<tbCargos> result = new List<tbCargos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Cargo_Id };
                result = db.Query<tbCargos>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbCargos> find(int Cargo_Id)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Cargar;

            List<tbCargos> result = new List<tbCargos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Cargo_Id };
                result = db.Query<tbCargos>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbCargos find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCargos item)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cargo_Descripcion", item.Cargo_Descripcion);
                parameter.Add("@Cargo_UsuarioCreacion", 1);
                parameter.Add("@Cargo_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbCargos> List()
        {
            string sql = ScriptsBaseDeDatos.Cargos_Listar;

            List<tbCargos> result = new List<tbCargos>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbCargos>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbCargos item)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cargo_Id", item.Cargo_Id);
                parameter.Add("@Cargo_Descripcion", item.Cargo_Descripcion);
                parameter.Add("@Cargo_UsuarioCreacion", 1);
                parameter.Add("@Cargo_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbCargos IRepository<tbCargos>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
