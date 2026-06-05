using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class BITACORA
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string usuario;
		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}

		private DateTime fecha;
		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private string evento;
		public string Evento
		{
			get { return evento; }
			set { evento = value; }
		}

		private string informacion;
		public string Informacion
		{
			get { return informacion; }
			set { informacion = value; }
		}

		private int criticidad;
		public int Criticidad
		{
			get { return criticidad; }
			set { criticidad = value; }
		}



	}
}