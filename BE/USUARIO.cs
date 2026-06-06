using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class USUARIO
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string contrasena;
		public string Contrasena
		{
			get { return contrasena; }
			set { contrasena = value; }
		}


        public override string ToString()
        {
            return $"{nombre}";
        }



	}
}
