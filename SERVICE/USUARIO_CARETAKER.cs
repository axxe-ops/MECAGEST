using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class USUARIO_CARETAKER
    {
        DAL.MP_AUDITORIA mapperAuditoria = new DAL.MP_AUDITORIA();
        public void GuardarEnAuditoria(USUARIO_MEMENTO memento, int idUsuario, string nombre)
        {            
            mapperAuditoria.Insertar(memento,idUsuario,nombre);
        }

    }
}
