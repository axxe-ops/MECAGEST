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
        public override void Deletear(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public override List<USUARIO> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Updatear(USUARIO obj)
        {
            throw new NotImplementedException();
        }

        public BE.USUARIO ValidarUsuario(USUARIO usuario)
        {            
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("nombre", usuario.Nombre));
            parametros.Add(acceso.CrearParametro("contraseña", usuario.Contraseña));

            acceso.Abrir();
            DataTable dt = acceso.Leer("sp_ValidarUsuario", parametros);
            acceso.Cerrar();

            if (dt.Rows.Count == 1)
            {                
                BE.USUARIO usuarioEncontrado = new BE.USUARIO();
                usuarioEncontrado.Id = Convert.ToInt32(dt.Rows[0]["id"]);
                usuarioEncontrado.Nombre = dt.Rows[0]["nombre"].ToString();
                usuarioEncontrado.Contraseña = dt.Rows[0]["contraseña"].ToString();

                return usuarioEncontrado;
            }

            return null;
        }
    }
}
