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
    public class MP_PERMISO 
    {
        public ACCESO acceso = new ACCESO();
        public List<BE.COMPONENTE> ObtenerTodos()
        {
            List<BE.COMPONENTE> listaHijos = new List<BE.COMPONENTE>();

            acceso.Abrir();
            System.Data.DataTable dt = acceso.Leer("sp_ObtenerTodosLosPermisos", null);
            acceso.Cerrar();

            foreach (System.Data.DataRow row in dt.Rows)
            {
                int idActual = Convert.ToInt32(row["id_permiso"]);
                BE.COMPONENTE hijo;
                if (row["tipo"].ToString() == "COMPUESTO")
                {
                    hijo = new BE.PermisoCompuesto();
                    // RECURSIVIDAD: Le pido al hijo que busque a sus propios hijos
                    List<BE.COMPONENTE> nietos = ObtenerHijos((int)row["id_permiso"]);

                    foreach (var nieto in nietos)
                    {
                        ((BE.PermisoCompuesto)hijo).Agregar(nieto);
                    }
                }
                else
                {
                    hijo = new BE.PermisoSimple();
                }

                hijo.Id = idActual;
                hijo.Nombre = row["nombre"].ToString();
                listaHijos.Add(hijo);
            }
            return listaHijos;
        }

        // 2. Obtener los hijos de un compuesto específico
        public List<BE.COMPONENTE> ObtenerHijos(int idPadre)
        {
            List<BE.COMPONENTE> listaHijos = new List<BE.COMPONENTE>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("idPadre", idPadre));

            acceso.Abrir();
            DataTable tabla = acceso.Leer("sp_ObtenerHijosPorPadre", parametros);
            acceso.Cerrar();

            foreach (System.Data.DataRow row in tabla.Rows)
            {
                BE.COMPONENTE hijo;
                string tipo = row["tipo"].ToString();

                if (tipo == "COMPUESTO")
                {
                    hijo = new BE.PermisoCompuesto();
                }
                else 
                {
                    hijo = new BE.PermisoSimple();
                }

                hijo.Id = (int)row["id_permiso"];
                hijo.Nombre = row["nombre"].ToString();

                listaHijos.Add(hijo);

            }

            return listaHijos;

        }

        // 3. Asignar una relación (Guardar en la tabla PERMISO_HIJO)
        public void GuardarRelacion(COMPONENTE Padre, COMPONENTE Hijo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("idPadre", Padre.Id));
            parametros.Add(acceso.CrearParametro("idHijo", Hijo.Id));

            acceso.Abrir();
            int res = acceso.Escribir("sp_GuardarRelacionPermisos", parametros);
            acceso.Cerrar();

        }

        // 4. Asignar un permiso a un usuario (Guardar en la tabla USUARIO_PERMISO)
        public void AsignarPermisoAUsuario(int idUsuario, int idPermiso)
        {
            // INSERT INTO USUARIO_PERMISO (id_usuario, id_permiso) VALUES (@u, @p)
        }


    }
}
