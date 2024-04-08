
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
    public class MunicipioRepository : IRepository<tbMunicipios>
    {
        public RequestStatus Delete(string Munic_Id)
        {
            string sql = ScriptsBaseDeDatos.Municipios_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Munic_Id", Munic_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbMunicipios item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbMunicipios> Details(string Munic_Id)
        {
            string sql = ScriptsBaseDeDatos.Municipios_Cargar;

            List<tbMunicipios> result = new List<tbMunicipios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Munic_Id };
                result = db.Query<tbMunicipios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbMunicipios> find(string Munic_Id)
        {
            string sql = ScriptsBaseDeDatos.Municipios_Cargar;

            List<tbMunicipios> result = new List<tbMunicipios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Munic_Id };
                result = db.Query<tbMunicipios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbMunicipios find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbMunicipios item)
        {
            string sql = ScriptsBaseDeDatos.Municipios_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Munic_Descripcion", item.Munic_Descripcion);
                parameter.Add("@Munic_UsuarioCreacion", 1);
                parameter.Add("@Munic_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbMunicipios> List()
        {
            string sql = ScriptsBaseDeDatos.Municipios_Listar;

            List<tbMunicipios> result = new List<tbMunicipios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbMunicipios>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbMunicipios item)
        {
            string sql = ScriptsBaseDeDatos.Municipios_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Munic_Id", item.Munic_Id);
                parameter.Add("@Munic_Descripcion", item.Munic_Descripcion);
                parameter.Add("@Munic_UsuarioModificacion", 1);
                parameter.Add("@Munic_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbMunicipios IRepository<tbMunicipios>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
