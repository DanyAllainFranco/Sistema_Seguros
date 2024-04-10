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
    public class RolesRepository : IRepository<tbRoles>
    {
        public RequestStatus Delete(tbRoles item)
        {
            throw new NotImplementedException();
        }

        public RequestStatus EliminarRol(int Roles_Id)
        {
            string sql = ScriptsBaseDeDatos. Rol_Eliminar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Roles_Id", Roles_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();

        }
        

        public RequestStatus EliminarPantallaPorRol(int Papro_Id)
        {
            string sql = ScriptsBaseDeDatos.PanRo_Eliminar;
            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Papro_Id", Papro_Id);

                var result = db.Execute(
                    sql, parametro,
                    commandType: CommandType.StoredProcedure
                );

                string mensaje = (result == 1) ? "exito" : "error";

                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };

            };
        }

        public tbRoles Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbRoles find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus InsertPantallasRoles(tbPantallasPorRoles item)
        {
            string sql = ScriptsBaseDeDatos.PanRo_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Roles_Id", item.Roles_Id);
                parameter.Add("@Panta_Id", item.Panta_Id);
                parameter.Add("@Papro_UsuarioCreacion", 1);
                parameter.Add("@Papro_FechaCreacion", DateTime.Now);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "exito" : "error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };

                //var result = db.QueryFirst(sql, parameter, commandType: CommandType.Text);

                //return result;
            }
        }

        public RequestStatus Insert(tbRoles item)
        {
            string sql = ScriptsBaseDeDatos.Rol_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Roles_Descripcion", item.Roles_Descripcion);
                parameter.Add("@Roles_Creacion", 1);
                parameter.Add("@Roles_FechaCreacion", DateTime.Now);
                parameter.Add("@Roles_id", dbType: DbType.Int32, direction: ParameterDirection.Output); // Agrega el parámetro de salida

                db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                int Roles_id = parameter.Get<int>("@Roles_id"); // Obtén el nuevo ID del parámetro de salida

                string mensaje = (Roles_id > 0) ? "exito" : "error";
                return new RequestStatus { CodeStatus = Roles_id, MessageStatus = mensaje };
            }
        }


        public IEnumerable<tbRoles> List()
        {
            string sql = ScriptsBaseDeDatos.Rol_Listar;

            List<tbRoles> result = new List<tbRoles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbRoles>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public IEnumerable<tbRoles> findObtenerId(string Roles_Descripcion, int usuario_creacion, DateTime fecha_creacion)
            {
            string sql = ScriptsBaseDeDatos.Rol_ObtenerId;

            List<tbRoles> result = new List<tbRoles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Roles_Descripcion, usuario_creacion, fecha_creacion };
                result = db.Query<tbRoles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbPantallasPorRoles> ObtenerRol(int Roles_Id)
        {
            string sql = ScriptsBaseDeDatos.Rol_Obtener;

            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Roles_Id = Roles_Id };
                result = db.Query<tbPantallasPorRoles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbPantallasPorRoles> BuscarPantallasPorRol(int Roles_Id)
        {
            string sql = ScriptsBaseDeDatos.PanRo_Buscar;

            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Roles_Id = Roles_Id };
                result = db.Query<tbPantallasPorRoles>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public RequestStatus Update(tbRoles item)
        {
            string sql = ScriptsBaseDeDatos.Rol_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Roles_Id", item.Roles_Id);
                parameter.Add("@Roles_Descripcion", item.Roles_Descripcion);
                parameter.Add("@Roles_Modificacion", 1);
                parameter.Add("@Roles_FechaModificacion", DateTime.Now);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                string mensaje = (result > 0) ? "exito" : "error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };
            }

            //throw new NotImplementedException();
        }
    }
}
