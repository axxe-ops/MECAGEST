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
    public class MP_AUDITORIA
    {
        public ACCESO acceso = new ACCESO();

        public void Insertar(USUARIO_MEMENTO memento, int idUsuario, string nombre)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_usuario", idUsuario));
            parametros.Add(acceso.CrearParametro("nombre_anterior", memento.Nombre)); 
            parametros.Add(acceso.CrearParametro("usuario_editor", nombre)); //quien hizo el cambio

            try
            {
                acceso.Abrir();
                int res = acceso.Escribir("sp_AuditoriaUsuario_Insertar", parametros);
                acceso.Cerrar();
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al registrar auditoría: " + ex.Message);
            }
        }

        public DataTable ObtenerHistorial()
        {
            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_Auditoria_ObtenerHistorial", null);
                acceso.Cerrar();

                return dt;
            }
            catch (Exception ex) 
            {
                acceso.Cerrar();
                throw new Exception("Error al leer el historial de la auditoria");

            }


        }

        public object ObtenerHistorialPorId(int idUsuario)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_usuario", idUsuario));

            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_Auditoria_ObtenerHistorialDeUnUsuario", parametros);
                acceso.Cerrar();

                return dt;
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al leer el historial de la auditoria de un solo usuario");

            }
        }
    }
}
