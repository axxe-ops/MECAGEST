using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MP_IDIOMA : MAPPER<BE.IDIOMA>
    {
        public override void Eliminar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public override void Insertar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public override List<IDIOMA> Listar()
        {
            List<IDIOMA> lista = new List<IDIOMA>();
            
            try
            {
                acceso.Abrir();
                DataTable dt = acceso.Leer("sp_ListarIdiomas", null);
                acceso.Cerrar();

                foreach (DataRow row in dt.Rows)
                {
                    IDIOMA idioma = new IDIOMA();
                    idioma.Id = Convert.ToInt32(row["id"]);
                    idioma.Nombre = row["nombre"].ToString();
                    lista.Add(idioma);
                }
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al listar los idiomas.", ex);
            }
            return lista;

        }

        public override void Modificar(IDIOMA obj)
        {
            throw new NotImplementedException();
        }

        public int InsertarIdioma(IDIOMA obj)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("nombre", obj.Nombre));

            try
            {
                acceso.Abrir();
                int nuevoId = Convert.ToInt32(acceso.EjecutarEscalar("sp_InsertarIdioma", parametros));
                acceso.Cerrar();
                return nuevoId;
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al insertar idioma nuevo", ex);
            }

        }

        public List<IDIOMA> Listar(IDIOMA obj)
        {
            List<IDIOMA> lista = new List<IDIOMA>();

            try
            {
                
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al listar los idiomas.", ex);
            }
            return lista;

        }

        public string BuscarTexto(string nombreEtiqueta, int id)
        {
            string texto = "";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre_etiqueta", nombreEtiqueta));
            parametros.Add(acceso.CrearParametro("@id_idioma", id));

            try
            {
                acceso.Abrir();
                var resultado = acceso.Leer("sp_ObtenerTraduccion", parametros);
                acceso.Cerrar();

                if (resultado.Rows.Count > 0)
                {
                    texto = resultado.Rows[0]["texto"].ToString();
                }
                else
                {
                    texto = "";
                }
                
            }
            catch (Exception ex) 
            {
                acceso.Cerrar();
                throw new Exception("Error al buscar texto de traduccion", ex);
            }

            return texto;
        }

        public void InicializarIdioma(int idIdioma)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("id_idioma", idIdioma));

            try
            {
                acceso.Abrir();
                int res = acceso.Escribir("sp_InicializarIdioma", parametros);
                acceso.Cerrar();
            }
            catch (Exception ex)
            {
                acceso.Cerrar();
                throw new Exception("Error al inicializar las etiquetas para el nuevo idioma.", ex);
            }
        }

        public void CambiarIdioma(int idIdiomaPorDefecto)
        {
            
        }
    }
}
