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

        public override List<COMPONENTE> ObtenerPermisos()
        {
            return listaPermisosHijos;
        }

        public override void Remover(COMPONENTE componente)
        {
            listaPermisosHijos.Remove(componente);
        }
    }
}