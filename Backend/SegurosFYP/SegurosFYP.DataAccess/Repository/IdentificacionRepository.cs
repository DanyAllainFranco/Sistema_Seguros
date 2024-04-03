﻿using Dapper;
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
    public class IdentificacionRepository : IRepository<tbIdentificaciones>
    {
        public RequestStatus Delete(tbIdentificaciones item)
        {
            string sql = ScriptsBaseDeDatos.Ident_Eliminar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Ident_Id", item.Ident_Id);

                parameter.Add("@Ident_UsuarioModificacion", item.Ident_UsuarioModificacion);
                parameter.Add("@Ident_FechaModificacion", item.Ident_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public tbIdentificaciones Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbIdentificaciones find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbIdentificaciones item)
        {
            string sql = ScriptsBaseDeDatos.Ident_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tiden_Id", item.Tiden_Id);
                parameter.Add("@Ident_NumeroIdentificacion", item.Ident_NumeroIdentificacion);
                parameter.Add("@Ident_FechaNacimiento", item.Ident_FechaNacimiento);
                parameter.Add("@Ident_LugarNacimiento", item.Ident_LugarNacimiento);

                parameter.Add("@Ident_UsuarioCreacion", item.Ident_UsuarioCreacion);
                parameter.Add("@Ident_FechaCreacion", item.Ident_FechaCreacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbIdentificaciones> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbIdentificaciones item)
        {
            string sql = ScriptsBaseDeDatos.Ident_Modificar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Tiden_Id", item.Tiden_Id);
                parameter.Add("@Ident_NumeroIdentificacion", item.Ident_NumeroIdentificacion);
                parameter.Add("@Ident_FechaNacimiento", item.Ident_FechaNacimiento);
                parameter.Add("@Ident_LugarNacimiento", item.Ident_LugarNacimiento);

                parameter.Add("@Ident_UsuarioModificacion", item.Ident_UsuarioModificacion);
                parameter.Add("@Ident_FechaModificacion", item.Ident_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
    }
}
