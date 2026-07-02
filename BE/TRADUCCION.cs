using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TRADUCCION
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private ETIQUETA etiqueta;
		public ETIQUETA Etiqueta
		{
			get;
			set;
		}

        public int EtiquetaId
        {
            get { return Etiqueta != null ? Etiqueta.Id : 0; }
        }

        public string EtiquetaNombre 
        {
            get { return Etiqueta != null ? Etiqueta.Nombre : ""; }
        }

        private IDIOMA idioma;
		public IDIOMA Idioma
		{
			get { return idioma; }
			set { idioma = value; }
		}

		private string texto;
		public string Texto
		{
			get { return texto; }
			set { texto = value; }
		}

	}
}
