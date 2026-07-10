using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_VERIFICARDIGITOS
    {
        ACCESO acceso = new ACCESO();
        public void GuardarDVV(string nombreTabla, int nuevoDVV)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombreTabla", nombreTabla));
            parametros.Add(acceso.CrearParametro("@ValorDVV", nuevoDVV));

            try
            {
                acceso.Abrir();
                int res = acceso.Escribir("sp_GuardarDVV", parametros);
                acceso.Cerrar();

            }catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al Guardar digitos verificadores verticales (DVV)", ex);

            }
        }

        public int ObtenerDVV(string nombreTabla)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombreTabla", nombreTabla));

            try
            {
                acceso.Abrir();
                object resultado = acceso.EjecutarEscalar("sp_ObtenerDVV", parametros);
                acceso.Cerrar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    return Convert.ToInt32(resultado);
                }

                return 0;
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al Guardar digitos verificadores verticales (DVV)", ex);
            }
        }
    }
}

