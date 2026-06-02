using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class SESSIONMANAGER
    {
        USUARIO usuario;
        private static SESSIONMANAGER instancia;       
        private int contadorIntentosFallidos;
        public SESSIONMANAGER() { }

        public static SESSIONMANAGER ObtenerInstancia()
        {
            if(instancia == null)
            {
                throw new Exception("No hay una sesión iniciada.");
            }
            else
            {
                return instancia;
            }                
        }
        public void Login(USUARIO usuario)
        {
            if(instancia == null)
            {
                instancia = new SESSIONMANAGER();
                instancia.usuario = usuario;
            }
            else
            {
                throw new Exception("Ya hay una sesión iniciada.");
            }

        }
        public void Logout() 
        {
            if (instancia != null)
            {
                instancia = null;
            }
            else
            {
                throw new Exception("No hay ninguna sesión iniciada.");
            }

        }


    }
}
