using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PERMISO_BLL
    {
        DAL.MP_PERMISO mapperPermiso = new DAL.MP_PERMISO();

        //CHEQUEAR BIEN - ME DA PROBLEMAS!

        //public void InicializarArbolPermisos()
        //{
        //    MP_PERMISO mapper = new MP_PERMISO();

        //    // 1. Obtenemos las raíces (padres que no tienen nadie arriba)
        //    List<BE.COMPONENTE> raices = mapper.ObtenerRaices();

        //    // 2. Cargamos recursivamente toda la estructura
        //    foreach (var nodo in raices)
        //    {
        //        CargarHijosRecursivo(nodo, mapper);
        //    }
        //}

        //private void CargarHijosRecursivo(BE.COMPONENTE componente, MP_PERMISO mapper)
        //{
        //    // Solo si es compuesto puede tener hijos
        //    if (componente is BE.PermisoCompuesto compuesto)
        //    {
        //        List<BE.COMPONENTE> hijos = mapper.ObtenerHijos(compuesto);

        //        foreach (var hijo in hijos)
        //        {
        //            compuesto.Agregar(hijo); // Patrón Composite: agregamos el componente

        //            // Recursividad: si el hijo también es compuesto, sigue bajando
        //            CargarHijosRecursivo(hijo, mapper);
        //        }
        //    }
        //}

    }
}
