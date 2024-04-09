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
    public class TipoArticuloMedicoRepository : IRepository<tbTipoArticuloMedico>
    {
        public RequestStatus Delete(int Tarme_Id)
        {
            string sql = ScriptsBaseDeDatos.TipoArticuloMedico_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tarme_Id", Tarme_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbTipoArticuloMedico item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbTipoArticuloMedico> Details(int? Tarme_Id)
        {
            string sql = ScriptsBaseDeDatos.TipoArticuloMedico_Cargar;

            List<tbTipoArticuloMedico> result = new List<tbTipoArticuloMedico>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Tarme_Id };
                result = db.Query<tbTipoArticuloMedico>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbTipoArticuloMedico> find(int Tarme_Id)
        {
            string sql = ScriptsBaseDeDatos.TipoArticuloMedico_Cargar;

            List<tbTipoArticuloMedico> result = new List<tbTipoArticuloMedico>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Tarme_Id };
                result = db.Query<tbTipoArticuloMedico>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbTipoArticuloMedico find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTipoArticuloMedico item)
        {
            string sql = ScriptsBaseDeDatos.TipoArticuloMedico_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tarme_Id", item.Tarme_Id);
                parameter.Add("@Tarme_Tipo", item.Tarme_Tipo);
                parameter.Add("@Tarme_Descripcion", item.Tarme_Descripcion);
                parameter.Add("@Tarme_UsuarioCreacion", 1);
                parameter.Add("@Tarme_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbTipoArticuloMedico> List()
        {
            string sql = ScriptsBaseDeDatos.TipoArticuloMedico_Listar;

            List<tbTipoArticuloMedico> result = new List<tbTipoArticuloMedico>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbTipoArticuloMedico>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbTipoArticuloMedico item)
        {
            string sql = ScriptsBaseDeDatos.TipoArticuloMedico_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tarme_Id", item.Tarme_Id);
                parameter.Add("@Tarme_Tipo", item.Tarme_Tipo);
                parameter.Add("@Tarme_Descripcion", item.Tarme_Descripcion);
                parameter.Add("@Tarme_UsuarioModificacion", 1);
                parameter.Add("@Tarme_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbTipoArticuloMedico IRepository<tbTipoArticuloMedico>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
