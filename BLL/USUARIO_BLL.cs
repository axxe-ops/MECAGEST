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

        } 


    }
}
