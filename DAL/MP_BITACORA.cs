using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_BITACORA : MAPPER<BE.BITACORA>
    {
        public ACCESO acceso = new ACCESO();

        
        public override void Insertar(BITACORA obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("usuario",obj.Usuario));
            parametros.Add(acceso.CrearParametro("fecha", obj.Fecha));
            parametros.Add(acceso.CrearParametro("evento", obj.Evento));
            parametros.Add(acceso.CrearParametro("informacion", obj.Informacion));
            parametros.Add(acceso.CrearParametro("criticidad", obj.Criticidad));

            acceso.Abrir();
            int res = acceso.Escribir("sp_InsertarBitacora", parametros);
            acceso.Cerrar();

        }

        public override void Updatear(BITACORA obj)
        {
            throw new NotImplementedException();
        }

        public override void Deletear(BITACORA obj)
        {
            throw new NotImplementedException();
        }

        public List<BE.BITACORA> Listar(DateTime desde, DateTime hasta, string usuario, int criticidad)
        {
            List<BE.BITACORA> lista = new List<BE.BITACORA>();

            // Preparar parámetros
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("desde", desde));
            parametros.Add(acceso.CrearParametro("hasta", hasta));
            parametros.Add(acceso.CrearParametro("usuario", usuario));
            parametros.Add(acceso.CrearParametro("criticidad", criticidad));

            acceso.Abrir();
            DataTable dt = acceso.Leer("sp_ConsultarBitacora", parametros);
            acceso.Cerrar();

            foreach (DataRow row in dt.Rows)
            {
                lista.Add(new BE.BITACORA
                {
                    Id = (int)row["id_bitacora"],
                    Usuario = row["usuario"].ToString(),
                    Fecha = Convert.ToDateTime(row["fecha"]),
                    Evento = row["evento"].ToString(),
                    Informacion = row["informacion"].ToString(),
                    Criticidad = (int)row["criticidad"]
                });
            }
            return lista;
        }

        public override List<BITACORA> Listar()
        {
            throw new NotImplementedException();
        }
    }

}

