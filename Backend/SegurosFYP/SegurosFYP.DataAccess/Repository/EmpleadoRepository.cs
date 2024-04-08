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
    public class EmpleadoRepository : IRepository<tbEmpleados>
    {
        public RequestStatus Delete(int Emple_Id)
        {
            string sql = ScriptsBaseDeDatos.Empleados_Delete;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Emple_Id", Emple_Id);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }

            throw new NotImplementedException();
        }

        public RequestStatus Delete(tbEmpleados item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEmpleados> Details(int? Emple_Id)
        {
            string sql = ScriptsBaseDeDatos.Empleados_Cargar;

            List<tbEmpleados> result = new List<tbEmpleados>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Emple_Id };
                result = db.Query<tbEmpleados>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public IEnumerable<tbEmpleados> DropDownList()
        {
            string sql = ScriptsBaseDeDatos.Empleados_DropDownList;

            List<tbEmpleados> result = new List<tbEmpleados>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbEmpleados>(sql, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public IEnumerable<tbEmpleados> find(int Emple_Id)
        {
            string sql = ScriptsBaseDeDatos.Empleados_Cargar;

            List<tbEmpleados> result = new List<tbEmpleados>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameters = new { Emple_Id };
                result = db.Query<tbEmpleados>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public tbEmpleados find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbEmpleados item)
        {
            string sql = ScriptsBaseDeDatos.Empleados_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Cargo_Id", item.Cargo_Id);
                parameter.Add("@Emple_UsuarioCreacion", 1);
                parameter.Add("@Emple_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbEmpleados> List()
        {
            string sql = ScriptsBaseDeDatos.Empleados_Listar;

            List<tbEmpleados> result = new List<tbEmpleados>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbEmpleados>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEmpleados item)
        {
            string sql = ScriptsBaseDeDatos.Empleados_Actualizar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Emple_Id", item.Emple_Id);
                parameter.Add("@Cargo_Id", item.Cargo_Id);
                parameter.Add("@Emple_UsuarioCreacion", 1);
                parameter.Add("@Emple_FechaCreacion", DateTime.Now);
                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);
                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        tbEmpleados IRepository<tbEmpleados>.Details(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
