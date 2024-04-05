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
    public class PolizaRepository : IRepository<tbPolizas>
    {
        public RequestStatus Delete(tbPolizas item)
        {
            string sql = ScriptsBaseDeDatos.Poliz_Eliminar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Poliz_Id", item.Poliz_Id);

                parameter.Add("@Poliz_UsuarioModificacion", item.Poliz_UsuarioModificacion);
                parameter.Add("@Poliz_FechaModificacion", item.Poliz_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public tbPolizas Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbPolizas find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPolizas item)
        {
            string sql = ScriptsBaseDeDatos.Poliz_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Clien_Id", item.Clien_Id);
                parameter.Add("@Tipos_Id", item.Tipos_Id);
                parameter.Add("@Emple_Id", item.Emple_Id);
                parameter.Add("@Poliz_Cuotas", item.Poliz_Cuotas);
                parameter.Add("@Poliz_TipoPago", item.Poliz_TipoPago);
                parameter.Add("@Poliz_EstadoCuotasPoliza", item.Poliz_EstadoCuotasPoliza);

                parameter.Add("@Poliz_UsuarioCreacion", item.Poliz_UsuarioCreacion);
                parameter.Add("@Poliz_FechaCreacion", item.Poliz_FechaCreacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
        public int Numeration() 
        {
            string sql = ScriptsBaseDeDatos.Poliz_Numeracion;

            List<tbPolizas> list = new List<tbPolizas>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                list = db.Query<tbPolizas>(sql, commandType: CommandType.StoredProcedure).ToList();

                int result;

                if (!list.Any()) 
                {
                    result = 0;
                }
                else
                {
                    result = int.Parse(list.First().Poliz_Id.ToString());
                }

                return result;
            }
        }
        public IEnumerable<tbPolizas> List()
        {
            string sql = ScriptsBaseDeDatos.Poliz_Listar;

            List<tbPolizas> result = new List<tbPolizas>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                result = db.Query<tbPolizas>(sql, commandType: CommandType.Text).ToList();

                return result;
            }
            //throw new NotImplementedException();
        }

        public RequestStatus Update(tbPolizas item)
        {
            string sql = ScriptsBaseDeDatos.Poliz_Modificar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Clien_Id", item.Clien_Id);
                parameter.Add("@Tipos_Id", item.Tipos_Id);
                parameter.Add("@Emple_Id", item.Emple_Id);
                parameter.Add("@Poliz_Cuotas", item.Poliz_Cuotas);
                parameter.Add("@Poliz_TipoPago", item.Poliz_TipoPago);
                parameter.Add("@Poliz_EstadoCuotasPoliza", item.Poliz_EstadoCuotasPoliza);

                parameter.Add("@Poliz_UsuarioModificacion", item.Poliz_UsuarioModificacion);
                parameter.Add("@Poliz_FechaModificacion", item.Poliz_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
    }
}
