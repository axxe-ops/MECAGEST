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
    public class MP_USUARIO : MAPPER<BE.USUARIO>
    {
        public override void Eliminar(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(USUARIO obj)
        {
            throw new NotImplementedException();
        }
        public override void Modificar(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public override List<USUARIO> Listar()
        {
            List<USUARIO> listaUsuarios = new List<USUARIO>();

            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_ListarUsuarios", null);
                acceso.Cerrar();

                foreach (DataRow fila in dt.Rows)
                {
                    USUARIO u = new USUARIO();
                    u.Id = Convert.ToInt32(fila["id"]);
                    u.Nombre = fila["nombre"].ToString();
                    listaUsuarios.Add(u);
                }
            }
            catch (Exception ex)
            {                
                acceso.Cerrar();
                throw new Exception("Error al intentar listar los usuarios desde la base de datos.", ex);
            }

            return listaUsuarios;
        }
        public BE.USUARIO ValidarUsuario(USUARIO usuario)
        {            
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("nombre", usuario.Nombre));
            parametros.Add(acceso.CrearParametro("contrasena", usuario.Contrasena));

            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_ValidarUsuario", parametros);
                acceso.Cerrar();

                if (dt.Rows.Count == 1)
                {
                    BE.USUARIO usuarioEncontrado = new BE.USUARIO();
                    usuarioEncontrado.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                    usuarioEncontrado.Nombre = dt.Rows[0]["nombre"].ToString();
                    usuarioEncontrado.Contrasena = dt.Rows[0]["contrasena"].ToString();

                    return usuarioEncontrado;
                }
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al conectar con la base de datos durante la validación.", ex);
            }
            return null;
        }
    }
}
