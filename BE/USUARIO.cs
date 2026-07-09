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

		private List<COMPONENTE> permisos;
		public List<COMPONENTE> Permisos
		{
			get { return permisos; }
			set { permisos = value; }
		}

		private IDIOMA idiomaPreferido;
		public IDIOMA IdiomaPreferido
		{
			get { return idiomaPreferido; }
			set { idiomaPreferido = value; }
		}

        public override string ToString()
        {
            return $"{nombre}";
        }





        //------------------- Patron memento ----------------- (T06b. Use la BE.usuario como originator)
        public USUARIO_MEMENTO CrearMemento()
        {
            return new USUARIO_MEMENTO(this.Nombre);
        }
        public void Restaurar(USUARIO_MEMENTO memento)
        {
            this.Nombre = memento.Nombre;
        }

	}
}
