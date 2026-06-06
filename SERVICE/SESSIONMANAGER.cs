using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICE
{
    public class SESSIONMANAGER
    {
        public USUARIO usuario;
        private static SESSIONMANAGER instancia;
        
        public SESSIONMANAGER() { }

        public static SESSIONMANAGER ObtenerInstancia()
        {
            return instancia;
        }
        public static bool Login(USUARIO usu)
        {
            BLL.USUARIO_BLL gestorUsuario = new BLL.USUARIO_BLL();

            string contraseñaHasheada = ENCRIPTADO.Hashear(usu.Contrasena);
            usu.Contrasena = contraseñaHasheada;

            BE.USUARIO usuarioLogueado = gestorUsuario.ValidarUsuario(usu);

            if(usuarioLogueado != null)
            {
                if (instancia == null)
                {                    
                    instancia = new SESSIONMANAGER();
                    instancia.usuario = usu;
                    return true;
                }
                else
                {
                    MessageBox.Show("Ya existe una sesión iniciada en el sistema.", "Sesión Activa", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return false;                                     
                }
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta", "Sesión Activa",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }           
        }
        public bool Logout() 
        {
            if (instancia != null && instancia.usuario != null)
            {                
                //Bitacora
                                
                instancia.usuario = null;
                instancia = null;

                return true;
            }

            return false;            
        }


    }
}
