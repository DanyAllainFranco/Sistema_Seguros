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
    public class TiposIdentificacionesRepository : IRepository<tbTiposIdentificaciones>
    {
        public RequestStatus Delete(int Tiden_Id)
        {
            string sql = ScriptsBaseDeDatos.TiposIdentificaciones_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tiden_Id", Tiden_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbTiposIdentificaciones item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbTiposIdentificaciones> Details(int? Tiden_Id)
        {
            string sql = ScriptsBaseDeDatos.TiposIdentificaciones_Cargar;

            List<tbTiposIdentificaciones> result = new List<tbTiposIdentificaciones>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Tiden_Id };
                result = db.Query<tbTiposIdentificaciones>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbTiposIdentificaciones> find(int Tiden_Id)
        {
            string sql = ScriptsBaseDeDatos.TiposIdentificaciones_Cargar;

            List<tbTiposIdentificaciones> result = new List<tbTiposIdentificaciones>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Tiden_Id };
                result = db.Query<tbTiposIdentificaciones>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbTiposIdentificaciones find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTiposIdentificaciones item)
        {
            string sql = ScriptsBaseDeDatos.TiposIdentificaciones_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tiden_Id", item.Tiden_Id);
                parameter.Add("@Tiden_Descripcion", item.Tiden_Descripcion);
                parameter.Add("@Tiden_UsuarioCreacion", 1);
                parameter.Add("@Tiden_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbTiposIdentificaciones> List()
        {
            string sql = ScriptsBaseDeDatos.TiposIdentificaciones_Listar;

            List<tbTiposIdentificaciones> result = new List<tbTiposIdentificaciones>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbTiposIdentificaciones>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbTiposIdentificaciones item)
        {
            string sql = ScriptsBaseDeDatos.TiposIdentificaciones_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tiden_Id", item.Tiden_Id);
                parameter.Add("@Tiden_Descripcion", item.Tiden_Descripcion);
                parameter.Add("@Tiden_UsuarioModificacion", 1);
                parameter.Add("@Tiden_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbTiposIdentificaciones IRepository<tbTiposIdentificaciones>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
