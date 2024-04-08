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
    public class CausaAtencionMedicaRepository : IRepository<tbCausaAtencionMedica>
    {
        public RequestStatus Delete(int Catme_Id)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Catme_Id", Catme_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbCausaAtencionMedica item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCausaAtencionMedica> Details(int? Catme_Id)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Cargar;

            List<tbCausaAtencionMedica> result = new List<tbCausaAtencionMedica>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Catme_Id };
                result = db.Query<tbCausaAtencionMedica>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbCausaAtencionMedica> find(int Catme_Id)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Cargar;

            List<tbCausaAtencionMedica> result = new List<tbCausaAtencionMedica>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Catme_Id };
                result = db.Query<tbCausaAtencionMedica>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbCausaAtencionMedica find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbCausaAtencionMedica item)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Catme_Descripcion", item.Catme_Descripcion);
                parameter.Add("@Infor_Id", item.Infor_Id);
                parameter.Add("@Catme_UsuarioCreacion", 1);
                parameter.Add("@Catme_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbCausaAtencionMedica> List()
        {
            string sql = ScriptsBaseDeDatos.Cargos_Listar;

            List<tbCausaAtencionMedica> result = new List<tbCausaAtencionMedica>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbCausaAtencionMedica>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbCausaAtencionMedica item)
        {
            string sql = ScriptsBaseDeDatos.Cargos_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Catme_Id", item.Catme_Id);
                parameter.Add("@Catme_Descripcion", item.Catme_Descripcion);
                parameter.Add("@Infor_Id", item.Infor_Id);
                parameter.Add("@Catme_UsuarioCreacion", 1);
                parameter.Add("@Catme_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbCausaAtencionMedica IRepository<tbCausaAtencionMedica>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
