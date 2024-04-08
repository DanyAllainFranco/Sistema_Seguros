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
    public class PaisRepository : IRepository<tbPaises>
    {
        public RequestStatus Delete(int Paise_Id)
        {
            string sql = ScriptsBaseDeDatos.Paises_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Paise_Id", Paise_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbPaises item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPaises> Details(int? Paise_Id)
        {
            string sql = ScriptsBaseDeDatos.Paises_Cargar;

            List<tbPaises> result = new List<tbPaises>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Paise_Id };
                result = db.Query<tbPaises>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbPaises> find(int Paise_Id)
        {
            string sql = ScriptsBaseDeDatos.Paises_Cargar;

            List<tbPaises> result = new List<tbPaises>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Paise_Id };
                result = db.Query<tbPaises>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbPaises find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPaises item)
        {
            string sql = ScriptsBaseDeDatos.Paises_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Paise_Descripcion", item.Paise_Descripcion);
                parameter.Add("@Paise_Nacionalidad", item.Paise_Nacionalidad);
                parameter.Add("@Paise_UsuarioCreacion", 1);
                parameter.Add("@Paise_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbPaises> List()
        {
            string sql = ScriptsBaseDeDatos.Paises_Listar;

            List<tbPaises> result = new List<tbPaises>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbPaises>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbPaises item)
        {
            string sql = ScriptsBaseDeDatos.Paises_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Paise_Id", item.Paise_Id);
                parameter.Add("@Paise_Descripcion", item.Paise_Descripcion);
                parameter.Add("@Paise_Nacionalidad", item.Paise_Nacionalidad);
                parameter.Add("@Paise_UsuarioCreacion", 1);
                parameter.Add("@Paise_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbPaises IRepository<tbPaises>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
