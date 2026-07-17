using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class MP_TRADUCCION : MAPPER<BE.TRADUCCION>
    {
        public override void Eliminar(TRADUCCION obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(TRADUCCION obj)
        {
            throw new NotImplementedException();
        }

        public override List<TRADUCCION> Listar()
        {
            throw new NotImplementedException();
        }

        public override void Modificar(TRADUCCION obj)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_idioma", obj.Idioma.Id));
            parametros.Add(acceso.CrearParametro("id_etiqueta", obj.Etiqueta.Id));
            parametros.Add(acceso.CrearParametro("texto", obj.Texto));

            try
            {
                acceso.Abrir();
                int res = acceso.Escribir("sp_ActualizarTraduccion", parametros);
                acceso.Cerrar();

                if (res == 0)
                {
                    // Si entra aquí, significa que la combinación ID_IDIOMA + ID_ETIQUETA no existe en la tabla TRADUCCION
                    MessageBox.Show("No se encontró la fila en BD para ID Idioma: " + obj.Idioma.Id + " y ID Etiqueta: " + obj.Etiqueta.Id);
                }
            }
            catch (Exception ex) 
            {
                acceso.Cerrar();
                throw new Exception("Error modificar las traducciones.", ex);
            }

            
        }

        public List<TRADUCCION> ListarTraducciones(BE.IDIOMA idioma)
        {
            List<TRADUCCION> lista = new List<TRADUCCION>();
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_idioma", idioma.Id));

            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_ObtenerTraduccionesPorIdioma", parametros);
                acceso.Cerrar();

                foreach (DataRow row in dt.Rows)
                {                    
                    TRADUCCION traduccion = new TRADUCCION();
                    traduccion.Etiqueta = new ETIQUETA();

                    traduccion.Idioma = idioma;

                    traduccion.Etiqueta.Id = Convert.ToInt32(row["IdEtiqueta"]);
                    traduccion.Etiqueta.Nombre = row["Etiqueta"].ToString();
                    traduccion.Texto = row["Texto"].ToString();

                    lista.Add(traduccion);
                }
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al listar las traducciones para el idioma seleccionado.", ex);
            }

            return lista;
        }
    }
}
