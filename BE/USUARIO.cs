using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class USUARIO : IVerificarDigitos
    {
        public USUARIO()
        {
            permisos = new List<COMPONENTE>();
        }

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


        //------------------- Digitos Verificadores -----------------

        private int dvh;

        

        public int Dvh
        {
            get { return dvh; }
            set { dvh = value; }
        }


        public string CalcularDVH()
        {
            // Ordenamos para que el orden de los elementos en la lista no afecte el cálculo
            var permisosOrdenados = Permisos.OrderBy(p => p.Id).ToList();
            string listaPermisos = string.Join(",", permisosOrdenados.Select(p => p.Id));

            string datos = $"{Id}{Nombre}{Contrasena}{listaPermisos}";

            int suma = 0;
            for (int i = 0; i < datos.Length; i++)
            {
                suma += (int)datos[i] * (i + 1);
            }

            return suma.ToString();
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
