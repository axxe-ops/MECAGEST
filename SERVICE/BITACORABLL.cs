using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace SERVICE
{
    public class BITACORABLL
    {                
        DAL.MP_BITACORA mapperBitacora = new DAL.MP_BITACORA();
        public static void  Registrar(string evento, string detalle, int criticidad)
        {
            DAL.MP_BITACORA mapperBitacora = new DAL.MP_BITACORA();

            BE.BITACORA log = new BE.BITACORA();

            var sesion = SERVICE.SESSIONMANAGER.ObtenerInstancia();

            if (sesion != null && sesion.usuario != null)
            {
                log.Usuario = sesion.usuario.Nombre;
            }
            else
            {
                log.Usuario = "INVITADO";
            }

            log.Fecha = DateTime.Now;
            log.Evento = evento;
            log.Informacion = detalle;
            log.Criticidad = criticidad;

            mapperBitacora.Insertar(log);
        }
                
        public List<BE.BITACORA> Consultar(DateTime desde, DateTime hasta, string usuario, int criticidad)
        {            
            return mapperBitacora.Listar(desde, hasta, usuario, criticidad);
        }
    }
}

