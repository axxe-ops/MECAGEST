using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class TRADUCCIONBLL
    {
        DAL.MP_TRADUCCION mapperTraduccion = new DAL.MP_TRADUCCION();
        public List<TRADUCCION> ListarTraducciones(BE.IDIOMA idioma)
        {
            return mapperTraduccion.ListarTraducciones(idioma);
        }

        public void Modificar(TRADUCCION traduccion)
        {
            mapperTraduccion.Modificar(traduccion);
        }
    }
}
