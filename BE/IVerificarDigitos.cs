using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public interface IVerificarDigitos
    {
        int Id { get; set; }
        int Dvh { get; set; }
        string CalcularDVH();

    }
}