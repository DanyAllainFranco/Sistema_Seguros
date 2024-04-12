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
    public class UsuarioRepository : IRepository<tbUsuarios>
    {
        public RequestStatus Delete(int Usuar_Id)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Eliminar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Usuar_Id", Usuar_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbUsuarios item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbUsuarios> Details(int? Usuar_Id)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Cargar;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Usuar_Id };
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbUsuarios> find(int Usuar_Id)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Cargar;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Usuar_Id };
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbUsuarios find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbUsuarios item)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Usuar_Usuario", item.Usuar_Usuario);
                parameter.Add("@Usuar_Contrasena", item.Usuar_Contrasena);
                parameter.Add("@Emple_Id", item.Emple_Id);
                parameter.Add("@Roles_Id", item.Roles_Id);
                parameter.Add("@Usuar_Admin", item.Usuar_Admin);
                parameter.Add("@Usuar_UltimaSesion", DateTime.Now);
                parameter.Add("@Usuar_UsuarioCreacion", 1);
                parameter.Add("@Usuar_FechaCreacion", DateTime.Now);

                var result = db.Execute(sql,parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = ""};
            }
        }

        public IEnumerable<tbUsuarios> List()
        {
            string sql = ScriptsBaseDeDatos.Usuar_Listar;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbUsuarios>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbUsuarios> Login(string Usuario, string Contra)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Login;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { @Usuario = Usuario, @Contra = Contra };
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbUsuarios item)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Usuar_Id", item.Usuar_Id);
                parameter.Add("@Usuar_Usuario", item.Usuar_Usuario);
                parameter.Add("@Usuar_Contrasena", item.Usuar_Contrasena);
                parameter.Add("@Emple_Id", item.Emple_Id);
                parameter.Add("@Roles_Id", item.Roles_Id);
                parameter.Add("@Usuar_Admin", item.Usuar_Admin);
                parameter.Add("@Usuar_UltimaSesion", DateTime.Now);
                parameter.Add("@Usuar_UsuarioModificacion",1);
                parameter.Add("@Usuar_FechaModificacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public RequestStatus ReestablecerContra(tbUsuarios item)
        {
            string sql = ScriptsBaseDeDatos.Usuar_Restablecer;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Usuar_Id", item.Usuar_Id);
                parameter.Add("@Usuar_Contrasena", item.Usuar_Contrasena);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }


        tbUsuarios IRepository<tbUsuarios>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
