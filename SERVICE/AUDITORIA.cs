using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class AUDITORIA
    {
        DAL.MP_AUDITORIA mapperAuditoria = new DAL.MP_AUDITORIA();
        public object ObtenerHistorial(int idUsuario)
        {
            return mapperAuditoria.ObtenerHistorialPorId(idUsuario);
        }

        public DataTable ObtenerHistorial()
        {
            return mapperAuditoria.ObtenerHistorial();
        }
    }
}
