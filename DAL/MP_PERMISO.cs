using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_PERMISO : MAPPER<BE.COMPONENTE>
    {
        public List<COMPONENTE> ObtenerTodosLosPermisos()
        {
            List<BE.COMPONENTE> listaHijos = new List<BE.COMPONENTE>();

            acceso.Abrir();
            DataTable dt = acceso.Leer("sp_ObtenerTodosLosPermisos", null);
            acceso.Cerrar();

            foreach (DataRow row in dt.Rows)
            {
                int idActual = Convert.ToInt32(row["id_permiso"]);
                string tipo = row["tipo"].ToString();

                BE.COMPONENTE hijo;

                if (tipo == "COMPUESTO")
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

                if (hijo is BE.PermisoCompuesto compuesto)
                {
                    List<BE.COMPONENTE> nietos = ObtenerHijos(hijo.Id);
                    foreach (var nieto in nietos)
                    {
                        compuesto.Agregar(nieto);
                    }
                }

                listaHijos.Add(hijo);

            }

            return listaHijos;

        }

        public List<COMPONENTE> ObtenerPermisosUsuario(USUARIO usuario)
        {
            List<COMPONENTE> permisosRaiz = new List<COMPONENTE>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("idUsuario", usuario.Id));

            acceso.Abrir();
            DataTable dt = acceso.Leer("sp_ObtenerPermisosPorUsuario", parametros);
            acceso.Cerrar();

            foreach (DataRow row in dt.Rows)
            {
                COMPONENTE c;

                string tipo = row["tipo"].ToString();

                if (tipo == "COMPUESTO")
                    c = new PermisoCompuesto();
                else
                    c = new PermisoSimple();

                c.Id = Convert.ToInt32(row["id_permiso"]);
                c.Nombre = row["nombre"].ToString();


                CargarHijos(c); // Cargamos hijos de forma recursiva !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                permisosRaiz.Add(c);
            }
            return permisosRaiz;
        }

        private void CargarHijos(COMPONENTE padre)
        {
            if (padre is PermisoCompuesto)
            {
                List<SqlParameter> parametros = new List<SqlParameter>();
                parametros.Add(acceso.CrearParametro("id_Padre", padre.Id));

                acceso.Abrir();
                DataTable dtHijos = acceso.Leer("sp_ObtenerHijosDePermiso", parametros);
                acceso.Cerrar();

                foreach (DataRow row in dtHijos.Rows)
                {
                    COMPONENTE hijo;
                    string tipo = row["tipo"].ToString();

                    if (tipo == "COMPUESTO")
                        hijo = new PermisoCompuesto();
                    else
                        hijo = new PermisoSimple();

                    hijo.Id = Convert.ToInt32(row["id_permiso"]);
                    hijo.Nombre = row["nombre"].ToString();

                    padre.Agregar(hijo);

                    // Recursividad: si el hijo también es compuesto, buscará sus propios hijos
                    CargarHijos(hijo);
                }
            }
        }


        public override void Insertar(COMPONENTE obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("nombre", obj.Nombre));
            parametros.Add(acceso.CrearParametro("tipo", obj is PermisoCompuesto ? "COMPUESTO" : "SIMPLE"));

            SqlParameter paramId = new SqlParameter("@idPermiso", SqlDbType.Int);
            paramId.Direction = ParameterDirection.Output;
            parametros.Add(paramId);

            acceso.Abrir();
            acceso.Escribir("sp_CrearPermiso", parametros);
            acceso.Cerrar();


            obj.Id = (int)paramId.Value;
        }

        public override void Modificar(COMPONENTE obj)
        {
            throw new NotImplementedException();
        }

        public override void Eliminar(COMPONENTE obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_permiso", obj.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("sp_EliminarPermiso", parametros);
                acceso.Cerrar();
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al eliminar el permiso de la base de datos.", ex);
            }
        }

        public override List<COMPONENTE> Listar()
        {
            throw new NotImplementedException();
        }

        public void AsignarHijo(COMPONENTE padre, COMPONENTE hijo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("idPadre", padre.Id));
            parametros.Add(acceso.CrearParametro("idHijo", hijo.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("sp_AsignarRelacionPermisos", parametros);
                acceso.Cerrar();
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al vincular el permiso hijo al padre en la base de datos.", ex);
            }
        }

        public void DesvincularPermiso(COMPONENTE padre, COMPONENTE hijo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_padre", padre.Id));
            parametros.Add(acceso.CrearParametro("id_hijo", hijo.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("sp_EliminarRelacionPermisos", parametros);
                acceso.Cerrar();
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al desvincular el permiso.", ex);
            }
        }

        public void AsignarRolAUsuario(USUARIO usuario, COMPONENTE permiso)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_usuario", usuario.Id));
            parametros.Add(acceso.CrearParametro("id_permiso", permiso.Id));

            try
            {
                acceso.Abrir();
                acceso.Escribir("sp_AsignarPermisoAUsuario", parametros);
                acceso.Cerrar();
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al asignar el rol al usuario en la base de datos.", ex);
            }
        }

        public List<COMPONENTE> ObtenerRolesDeUsuario(USUARIO u)
        {
            List<COMPONENTE> lista = new List<COMPONENTE>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_usuario", u.Id));

            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_ObtenerRolesDeUsuario", parametros);
                acceso.Cerrar();

                foreach (DataRow row in dt.Rows)
                {
                    COMPONENTE c;
                    string tipo = row["tipo"].ToString();

                    if (tipo == "COMPUESTO")
                        c = new PermisoCompuesto();
                    else
                        c = new PermisoSimple();

                    c.Id = Convert.ToInt32(row["id_permiso"]);
                    c.Nombre = row["nombre"].ToString();

                    lista.Add(c);
                }

            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al obtener los roles de usuario con id.", ex);
            }

            return lista;
        }

        public List<COMPONENTE> ObtenerHijosDePermiso(int idPadre)
        {
            List<COMPONENTE> hijos = new List<COMPONENTE>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_padre", idPadre));

            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_ObtenerHijosDePermiso", parametros);
                acceso.Cerrar();

                foreach (DataRow row in dt.Rows)
                {
                    COMPONENTE hijo;
                    string tipo = row["tipo"].ToString();

                    if (tipo == "COMPUESTO")
                        hijo = new PermisoCompuesto();
                    else
                        hijo = new PermisoSimple();

                    hijo.Id = Convert.ToInt32(row["id_permiso"]);
                    hijo.Nombre = row["nombre"].ToString();

                    hijos.Add(hijo);
                }
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al intentar recuperar los hijos del permiso con ID: " + idPadre + ". Verifique la relación en la base de datos.", ex);
            }
            
            return hijos;
        }
    }
}
