using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public static class SEGURIDAD
    {
        public static bool TienePermiso(string nombrePermiso)
        {
            
            BE.USUARIO usuario = SESSIONMANAGER.ObtenerInstancia().usuario;

            if (usuario == null || usuario.Permisos == null) return false;

            foreach (var p in usuario.Permisos)
            {
                if (p.TienePermiso(nombrePermiso))
                {
                    return true;
                }
            }

            return false;
        }


    }
}
