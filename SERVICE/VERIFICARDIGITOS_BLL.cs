using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVICE
{
    public class VERIFICARDIGITOS_BLL
    {
        DAL.MP_VERIFICARDIGITOS mapperDigitos = new DAL.MP_VERIFICARDIGITOS();

        public void GuardarDVV(string nombreTabla, int nuevoDVV)
        {
            mapperDigitos.GuardarDVV(nombreTabla, nuevoDVV);
        }

        public List<string> VerificarIntegridad(List<IVerificarDigitos> lista, string nombreTabla)
        {
            List<string> errores = new List<string>();
            int sumaDVH = 0;

            foreach (var item in lista)
            {
                //Verificación Horizontal (Fila por fila)
                int dvhCalculado = int.Parse(item.CalcularDVH());

                if (item.Dvh != dvhCalculado)
                {
                    errores.Add($"ID {item.Id}: DVH incorrecto. BD:{item.Dvh} | Calculado:{dvhCalculado}"); 
                }

                sumaDVH += dvhCalculado;
            }

            //Verificación Vertical (Tabla completa)
            int dvvBase = mapperDigitos.ObtenerDVV(nombreTabla);

            if (sumaDVH != dvvBase)
            {
                errores.Add("Error DVV: La suma vertical no coincide con la base de datos.");
            }

            return errores;
        }

    }
}
