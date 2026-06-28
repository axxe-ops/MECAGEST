using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class PermisoSimple : COMPONENTE
    {
        public override void Agregar(COMPONENTE componente)
        {
            throw new NotImplementedException();
        }

        public override List<COMPONENTE> ObtenerHijos()
        {
            return new List<COMPONENTE>();
        }

        public override void Remover(COMPONENTE componente)
        {
            throw new NotImplementedException();
        }

        public override bool TienePermiso(string nombrePermiso)
        {
            return this.Nombre == nombrePermiso;
        }
    }
}