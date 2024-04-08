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
    public class UnidadRepository : IRepository<tbUnidades>
    {
        public RequestStatus Delete(int Unida_Id)
        {
            string sql = ScriptsBaseDeDatos.Unidades_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Unida_Id", Unida_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbUnidades item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbUnidades> Details(int? Unida_Id)
        {
            string sql = ScriptsBaseDeDatos.Unidades_Cargar;

            List<tbUnidades> result = new List<tbUnidades>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Unida_Id };
                result = db.Query<tbUnidades>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbUnidades> find(int Unida_Id)
        {
            string sql = ScriptsBaseDeDatos.Unidades_Cargar;

            List<tbUnidades> result = new List<tbUnidades>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Unida_Id };
                result = db.Query<tbUnidades>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbUnidades find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbUnidades item)
        {
            string sql = ScriptsBaseDeDatos.Unidades_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Unida_Descripcion", item.Unida_Descripcion);
                parameter.Add("@Unida_UsuarioCreacion", 1);
                parameter.Add("@Unida_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbUnidades> List()
        {
            string sql = ScriptsBaseDeDatos.Unidades_Listar;

            List<tbUnidades> result = new List<tbUnidades>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbUnidades>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbUnidades item)
        {
            string sql = ScriptsBaseDeDatos.Unidades_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Unida_Id", item.Unida_Id);
                parameter.Add("@Unida_Descripcion", item.Unida_Descripcion);
                parameter.Add("@Unida_UsuarioModificacion", 1);
                parameter.Add("@Unida_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbUnidades IRepository<tbUnidades>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
