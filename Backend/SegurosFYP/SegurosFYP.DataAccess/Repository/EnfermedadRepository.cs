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
    public class EnfermedadRepository: IRepository<tbEnfermedades>
    {
        public RequestStatus Delete(int Enfer_Id)
        {
            string sql = ScriptsBaseDeDatos.Enfermedad_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Enfer_Id", Enfer_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbEnfermedades item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEnfermedades> Details(int? Enfer_Id)
        {
            string sql = ScriptsBaseDeDatos.Enfermedad_Cargar;

            List<tbEnfermedades> result = new List<tbEnfermedades>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Enfer_Id };
                result = db.Query<tbEnfermedades>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbEnfermedades> find(int Enfer_Id)
        {
            string sql = ScriptsBaseDeDatos.Enfermedad_Cargar;

            List<tbEnfermedades> result = new List<tbEnfermedades>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Enfer_Id };
                result = db.Query<tbEnfermedades>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbEnfermedades find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEnfermedades item)
        {
            string sql = ScriptsBaseDeDatos.Enfermedad_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Enfer_Descripcion", item.Enfer_Descripcion);
                parameter.Add("@Enfer_UsuarioCreacion", 1);
                parameter.Add("@Enfer_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbEnfermedades> List()
        {
            string sql = ScriptsBaseDeDatos.Enfermedad_Listar;

            List<tbEnfermedades> result = new List<tbEnfermedades>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbEnfermedades>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEnfermedades item)
        {
            string sql = ScriptsBaseDeDatos.Enfermedad_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Enfer_Id", item.Enfer_Id);
                parameter.Add("@Enfer_Descripcion", item.Enfer_Descripcion);
                parameter.Add("@Enfer_UsuarioModificacion", 1);
                parameter.Add("@Enfer_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbEnfermedades IRepository<tbEnfermedades>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
