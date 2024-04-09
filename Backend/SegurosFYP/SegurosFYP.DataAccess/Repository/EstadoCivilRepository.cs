
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
    public class EstadoCivilRepository : IRepository<tbEstadosCiviles>
    {
        public RequestStatus Delete(int Estad_Id)
        {
            string sql = ScriptsBaseDeDatos.EstadoC_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Estad_Id", Estad_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbEstadosCiviles item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstadosCiviles> Details(int? Estad_Id)
        {
            string sql = ScriptsBaseDeDatos.EstadoC_Detalles;

            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Estad_Id };
                result = db.Query<tbEstadosCiviles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbEstadosCiviles> find(int Estad_Id)
        {
            string sql = ScriptsBaseDeDatos.EstadoC_Cargar;

            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Estad_Id };
                result = db.Query<tbEstadosCiviles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbEstadosCiviles find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEstadosCiviles item)
        {
            string sql = ScriptsBaseDeDatos.EstadoC_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Estad_Descripcion", item.Estad_Descripcion);
                parameter.Add("@Estad_UsuarioCreacion", 1);
                parameter.Add("@Estad_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbEstadosCiviles> List()
        {
            string sql = ScriptsBaseDeDatos.EstadoC_Listar;

            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbEstadosCiviles>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEstadosCiviles item)
        {
            string sql = ScriptsBaseDeDatos.EstadoC_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Estad_Id", item.Estad_Id);
                parameter.Add("@Estad_Descripcion", item.Estad_Descripcion);
                parameter.Add("@Estad_UsuarioModificacion", 1);
                parameter.Add("@Estad_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbEstadosCiviles IRepository<tbEstadosCiviles>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
