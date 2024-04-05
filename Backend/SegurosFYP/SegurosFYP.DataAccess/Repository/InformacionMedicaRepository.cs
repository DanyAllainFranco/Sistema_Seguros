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
    public class InformacionMedicaRepository : IRepository<tbInformacionMedica>
    {
        public RequestStatus Delete(tbInformacionMedica item)
        {
            string sql = ScriptsBaseDeDatos.Inmed_Eliminar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Perso_Id", item.Perso_Id);

                parameter.Add("@Inmed_UsuarioModificacion", item.Inmed_UsuarioModificacion);
                parameter.Add("@Inmed_FechaModificacion", item.Inmed_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public tbInformacionMedica Details(int? id)
        {
            throw new NotImplementedException();
        }

        public tbInformacionMedica find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbInformacionMedica item)
        {
            string sql = ScriptsBaseDeDatos.Inmed_Insertar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Perso_Id", item.Perso_Id);
                parameter.Add("@Inmed_PesoKgs", item.Inmed_PesoKgs);
                parameter.Add("@Inmed_EstaturaMtrs", item.Inmed_EstaturaMtrs);
                parameter.Add("@Inmed_TipoSangre", item.Inmed_TipoSangre);
                parameter.Add("@Inmed_ReaccionesAlergicas", item.Inmed_ReaccionesAlergicas);
                parameter.Add("@Inmed_AumentoDisminucion", item.Inmed_AumentoDisminucion);
                parameter.Add("@Inmed_AumentoDisminucionPeso", item.Inmed_AumentoDisminucionPeso);
                parameter.Add("@Inmed_IngiereBebidasAlcoholicas", item.Inmed_IngiereBebidasAlcoholicas);
                parameter.Add("@Inmed_TipoAlcohol", item.Inmed_TipoAlcohol);
                parameter.Add("@Inmed_IngiereCantidad", item.Inmed_IngiereCantidad);
                parameter.Add("@Inmed_IngiereFrecuencia", item.Inmed_IngiereFrecuencia);
                parameter.Add("@Inmed_DrogasEstimulantes", item.Inmed_DrogasEstimulantes);
                parameter.Add("@Inmed_TipoDrogasEstimulantes", item.Inmed_TipoDrogasEstimulantes);
                parameter.Add("@Inmed_DrogasEstimulantesCantidad", item.Inmed_DrogasEstimulantesCantidad);
                parameter.Add("@Inmed_DrogasEstimulantesFrecuencia", item.Inmed_DrogasEstimulantesFrecuencia);
                parameter.Add("@Inmed_Fumar", item.Inmed_Fumar);
                parameter.Add("@Inmed_FumarCantidad", item.Inmed_FumarCantidad);
                parameter.Add("@Inmed_FumarFrecuencia", item.Inmed_FumarFrecuencia);
                parameter.Add("@Inmed_Enfermedad1", item.Inmed_Enfermedad1);
                parameter.Add("@Inmed_Enfermedad2", item.Inmed_Enfermedad2);
                parameter.Add("@Inmed_Enfermedad3", item.Inmed_Enfermedad3);
                parameter.Add("@Inmed_Enfermedad4", item.Inmed_Enfermedad4);
                parameter.Add("@Inmed_Enfermedad5", item.Inmed_Enfermedad5);
                parameter.Add("@Inmed_Enfermedad6", item.Inmed_Enfermedad6);
                parameter.Add("@Inmed_Enfermedad7", item.Inmed_Enfermedad7);
                parameter.Add("@Inmed_Enfermedad8", item.Inmed_Enfermedad8);
                parameter.Add("@Inmed_Enfermedad9", item.Inmed_Enfermedad9);

                parameter.Add("@Inmed_UsuarioCreacion", item.Inmed_UsuarioCreacion);
                parameter.Add("@Inmed_FechaCreacion", item.Inmed_FechaCreacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbInformacionMedica> List()
        {
            throw new NotImplementedException();
        }

        public RequestStatus Update(tbInformacionMedica item)
        {
            string sql = ScriptsBaseDeDatos.Inmed_Modificar;

            using (var db = new SqlConnection(SegurosFYPContext.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Perso_Id", item.Perso_Id);
                parameter.Add("@Inmed_PesoKgs", item.Inmed_PesoKgs);
                parameter.Add("@Inmed_EstaturaMtrs", item.Inmed_EstaturaMtrs);
                parameter.Add("@Inmed_TipoSangre", item.Inmed_TipoSangre);
                parameter.Add("@Inmed_ReaccionesAlergicas", item.Inmed_ReaccionesAlergicas);
                parameter.Add("@Inmed_AumentoDisminucion", item.Inmed_AumentoDisminucion);
                parameter.Add("@Inmed_AumentoDisminucionPeso", item.Inmed_AumentoDisminucionPeso);
                parameter.Add("@Inmed_IngiereBebidasAlcoholicas", item.Inmed_IngiereBebidasAlcoholicas);
                parameter.Add("@Inmed_TipoAlcohol", item.Inmed_TipoAlcohol);
                parameter.Add("@Inmed_IngiereCantidad", item.Inmed_IngiereCantidad);
                parameter.Add("@Inmed_IngiereFrecuencia", item.Inmed_IngiereFrecuencia);
                parameter.Add("@Inmed_DrogasEstimulantes", item.Inmed_DrogasEstimulantes);
                parameter.Add("@Inmed_TipoDrogasEstimulantes", item.Inmed_TipoDrogasEstimulantes);
                parameter.Add("@Inmed_DrogasEstimulantesCantidad", item.Inmed_DrogasEstimulantesCantidad);
                parameter.Add("@Inmed_DrogasEstimulantesFrecuencia", item.Inmed_DrogasEstimulantesFrecuencia);
                parameter.Add("@Inmed_Fumar", item.Inmed_Fumar);
                parameter.Add("@Inmed_FumarCantidad", item.Inmed_FumarCantidad);
                parameter.Add("@Inmed_FumarFrecuencia", item.Inmed_FumarFrecuencia);
                parameter.Add("@Inmed_Enfermedad1", item.Inmed_Enfermedad1);
                parameter.Add("@Inmed_Enfermedad2", item.Inmed_Enfermedad2);
                parameter.Add("@Inmed_Enfermedad3", item.Inmed_Enfermedad3);
                parameter.Add("@Inmed_Enfermedad4", item.Inmed_Enfermedad4);
                parameter.Add("@Inmed_Enfermedad5", item.Inmed_Enfermedad5);
                parameter.Add("@Inmed_Enfermedad6", item.Inmed_Enfermedad6);
                parameter.Add("@Inmed_Enfermedad7", item.Inmed_Enfermedad7);
                parameter.Add("@Inmed_Enfermedad8", item.Inmed_Enfermedad8);
                parameter.Add("@Inmed_Enfermedad9", item.Inmed_Enfermedad9);

                parameter.Add("@Inmed_UsuarioModificacion", item.Inmed_UsuarioModificacion);
                parameter.Add("@Inmed_FechaModificacion", item.Inmed_FechaModificacion);

                var result = db.Execute(sql, parameter, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
            //throw new NotImplementedException();
        }
    }
}
