using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class USUARIO_BLL
    {
        DAL.MP_USUARIO mapperUsuario = new DAL.MP_USUARIO();

        public BE.USUARIO ValidarUsuario(BE.USUARIO usu)
        {            
            return mapperUsuario.ValidarUsuario(usu);
        }

        public void InsertarUsuario(BE.USUARIO usu)
        {
            
        }        

        public void EliminarUsuario(BE.USUARIO usu)
        {

        }

        public void ModificarUsuario(BE.USUARIO usu)
        {
            mapperUsuario.Modificar(usu);
        }

        public List<USUARIO> Listar()
        {
            return mapperUsuario.Listar();
        }

        public void ActualizarIdiomaPreferido(USUARIO usuarioActual, IDIOMA nuevoIdioma)
        {
            mapperUsuario.ActualizarIdiomaPreferido(usuarioActual, nuevoIdioma);
        }

        public IDIOMA ObtenerIdiomaPreferido(USUARIO usuarioActual)
        {
            return mapperUsuario.ObtenerIdiomaPreferido(usuarioActual);
        }

        public USUARIO ObtenerUsuarioPorId(int idUsuarioAfectado)
        {
            return mapperUsuario.ObtenerUsuarioPorId(idUsuarioAfectado);
        }
    }
}
