using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class IDIOMABLL
    {
        private static IDIOMABLL instanciaIdioma;
        private IDIOMA idiomaActual;
        private List<IObserverIdioma> observadores = new List<IObserverIdioma>();

        public static IDIOMABLL ObtenerInstanciaIdioma()
        {
            if (instanciaIdioma == null)
            {
                instanciaIdioma = new IDIOMABLL();
            }
            return instanciaIdioma;
        }

        public IDIOMA IdiomaActual { get { return idiomaActual; } }
                
        public void Suscribir(IObserverIdioma obs) 
        { 
            observadores.Add(obs); 
        }
        public void Desuscribir(IObserverIdioma obs) 
        {
            observadores.Remove(obs); 
        }
        public void CambiarIdioma(IDIOMA nuevoIdioma)
        {
            idiomaActual = nuevoIdioma;
            foreach (var obs in observadores)
            {
                obs.ActualizarIdioma();
            }
        }
                
        public string ObtenerTraduccion(string nombreEtiqueta)
        {
            if (idiomaActual == null) return nombreEtiqueta;

            return BuscarTexto(nombreEtiqueta, idiomaActual.Id);
        }

        


        //--------------------- PARA LA DAL ---------------------

        DAL.MP_IDIOMA mapperIdioma = new DAL.MP_IDIOMA();
        public void Insertar(IDIOMA obj)
        {
            int nuevoId = mapperIdioma.InsertarIdioma(obj);

            mapperIdioma.InicializarIdioma(nuevoId); //se incializa para que ponga "" en todas las celdas
        }

        public void Modificar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public List<IDIOMA> Listar()
        {
            return mapperIdioma.Listar();
        }

        public List<IDIOMA> ObtenerTraduccionesPorIdioma(IDIOMA idiomaSeleccionado)
        {
            return mapperIdioma.Listar(idiomaSeleccionado);
        }

        private string BuscarTexto(string nombreEtiqueta, int id)
        {
            return mapperIdioma.BuscarTexto(nombreEtiqueta, id);
        }

        public void CambiarIdiomaPorDefecto()
        {
            List<IDIOMA> listaIdiomas = Listar();
            IDIOMA idiomaDefecto = null;

            foreach (IDIOMA i in listaIdiomas)
            {
                if (i.Id == 2) //2 es ingles
                {
                    idiomaDefecto = i;
                    break;
                }
            }

            if (idiomaDefecto != null)
            {
                CambiarIdioma(idiomaDefecto);
            }
        }
    }
}
