using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class PermisoCompuesto : COMPONENTE
    {
        public List<COMPONENTE> listaPermisosHijos = new List<COMPONENTE>();
        public override void Agregar(COMPONENTE componente)
        {
            listaPermisosHijos.Add(componente);
        }

        public override List<COMPONENTE> ObtenerHijos()
        {
            return listaPermisosHijos;
        }

        public override void Remover(COMPONENTE componente)
        {
            listaPermisosHijos.Remove(componente);
        }

        public override bool TienePermiso(string nombrePermiso)
        {
            if (this.Nombre == nombrePermiso) return true;

            foreach (var hijo in listaPermisosHijos)
            {
                if (hijo.TienePermiso(nombrePermiso)) return true;
            }

            return false;
        }
    }
}