using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class USUARIO_MEMENTO
    {
        public string Nombre { get; } 

        public USUARIO_MEMENTO(string nombre)
        {
            Nombre = nombre;
        }

    }
}