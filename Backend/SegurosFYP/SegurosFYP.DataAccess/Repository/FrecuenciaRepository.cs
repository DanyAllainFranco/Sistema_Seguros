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
    public class FrecuenciaRepository : IRepository<tbFrecuencias>
    {
        public RequestStatus Delete(int Frecu_Id)
        {
            string sql = ScriptsBaseDeDatos.Frecuencia_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Frecu_Id", Frecu_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbFrecuencias item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbFrecuencias> Details(int? Frecu_Id)
        {
            string sql = ScriptsBaseDeDatos.Frecuencia_Cargar;

            List<tbFrecuencias> result = new List<tbFrecuencias>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Frecu_Id };
                result = db.Query<tbFrecuencias>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbFrecuencias> find(int Frecu_Id)
        {
            string sql = ScriptsBaseDeDatos.Frecuencia_Cargar;

            List<tbFrecuencias> result = new List<tbFrecuencias>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Frecu_Id };
                result = db.Query<tbFrecuencias>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbFrecuencias find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbFrecuencias item)
        {
            string sql = ScriptsBaseDeDatos.Frecuencia_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Frecu_Descripcion", item.Frecu_Descripcion);
                parameter.Add("@Frecu_UsuarioCreacion", 1);
                parameter.Add("@Frecu_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbFrecuencias> List()
        {
            string sql = ScriptsBaseDeDatos.Frecuencia_Listar;

            List<tbFrecuencias> result = new List<tbFrecuencias>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbFrecuencias>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbFrecuencias item)
        {
            string sql = ScriptsBaseDeDatos.Frecuencia_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Frecu_Id", item.Frecu_Id);
                parameter.Add("@Frecu_Descripcion", item.Frecu_Descripcion);
                parameter.Add("@Frecu_UsuarioModificacion", 1);
                parameter.Add("@Frecu_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbFrecuencias IRepository<tbFrecuencias>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
