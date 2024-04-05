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
    public class PersonaRepository : IRepository<tbPersonas>
    {
        public RequestStatus Delete(tbPersonas item)
        {
            string sql = ScriptsBaseDeDatos.Perso_Eliminar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Perso_PrimerNombre", item.Perso_Id);
                parameter.Add("@Perso_UsuarioModificacion", item.Perso_UsuarioModificacion);
                parameter.Add("@Perso_FechaModificacion", item.Perso_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public tbPersonas Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbPersonas find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbPersonas item)
        {
            string sql = ScriptsBaseDeDatos.Perso_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Perso_PrimerNombre", item.Perso_PrimerNombre);
                if(item.Perso_SegundoNombre != "") 
                {
                    parameter.Add("@Perso_SegundoNombre", item.Perso_SegundoNombre);
                }
                parameter.Add("@Perso_PrimerApellido", item.Perso_PrimerApellido);
                if (item.Perso_SegundoApellido != "")
                {
                    parameter.Add("@Perso_SegundoApellido", item.Perso_SegundoApellido);
                }
                parameter.Add("@Perso_Sexo", item.Perso_Sexo);
                parameter.Add("@Ident_Id", item.Ident_Id);
                if (item.Estci_Id != 0)
                {
                    parameter.Add("@Estci_Id", item.Estci_Id);
                }
                if (item.Perso_Telefono != "")
                {
                    parameter.Add("@Perso_Telefono", item.Perso_Telefono);
                }
                if (item.Perso_CorreoElectronico != "")
                {
                    parameter.Add("@Perso_CorreoElectronico", item.Perso_CorreoElectronico);
                }
                if (item.Perso_Direccion != "")
                {
                    parameter.Add("@Perso_Direccion", item.Perso_Direccion);
                }
                if (item.Munic_Id != "")
                {
                    parameter.Add("@Munic_Id", item.Munic_Id);
                }
                if (item.Paise_Id != 0)
                {
                    parameter.Add("@Paise_Id", item.Paise_Id);
                }
                parameter.Add("@Poliz_Id", item.Poliz_Id);
                parameter.Add("@Paren_Id", item.Paren_Id);
                parameter.Add("@Perso_UsuarioCreacion", item.Perso_UsuarioCreacion);
                parameter.Add("@Perso_FechaCreacion", item.Perso_FechaCreacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbPersonas> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbPersonas item)
        {
            string sql = ScriptsBaseDeDatos.Perso_Modificar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Perso_PrimerNombre", item.Perso_PrimerNombre);
                if (item.Perso_SegundoNombre != "")
                {
                    parameter.Add("@Perso_SegundoNombre", item.Perso_SegundoNombre);
                }
                parameter.Add("@Perso_PrimerApellido", item.Perso_PrimerApellido);
                if (item.Perso_SegundoApellido != "")
                {
                    parameter.Add("@Perso_SegundoApellido", item.Perso_SegundoApellido);
                }
                parameter.Add("@Perso_Sexo", item.Perso_Sexo);
                parameter.Add("@Ident_Id", item.Ident_Id);
                if (item.Estci_Id != 0)
                {
                    parameter.Add("@Estci_Id", item.Estci_Id);
                }
                if (item.Perso_Telefono != "")
                {
                    parameter.Add("@Perso_Telefono", item.Perso_Telefono);
                }
                if (item.Perso_CorreoElectronico != "")
                {
                    parameter.Add("@Perso_CorreoElectronico", item.Perso_CorreoElectronico);
                }
                if (item.Perso_Direccion != "")
                {
                    parameter.Add("@Perso_Direccion", item.Perso_Direccion);
                }
                if (item.Munic_Id != "")
                {
                    parameter.Add("@Munic_Id", item.Munic_Id);
                }
                if (item.Paise_Id != 0)
                {
                    parameter.Add("@Paise_Id", item.Paise_Id);
                }
                parameter.Add("@Poliz_Id", item.Poliz_Id);
                parameter.Add("@Paren_Id", item.Paren_Id);
                parameter.Add("@Perso_UsuarioModificacion", item.Perso_UsuarioModificacion);
                parameter.Add("@Perso_FechaModificacion", item.Perso_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
        public int Numeration()
        {
            string sql = ScriptsBaseDeDatos.Perso_Numeracion;

            List<tbPersonas> list = new List<tbPersonas>();

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                list = db.Query<tbPersonas>(sql, commandType: CommandType.Text).ToList();

                int result = int.Parse(list.First().Perso_Id.ToString());

                return result;
            }
        }
    }
}
