using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PERMISO_BLL
    {
        DAL.MP_PERMISO mapperPermiso = new DAL.MP_PERMISO();

        public void AsignarHijo(COMPONENTE padreSeleccionado, COMPONENTE permisoNuevo)
        {
            if (!(padreSeleccionado is PermisoCompuesto))
                throw new Exception("Solo se pueden asignar hijos a permisos compuestos (roles).");

            mapperPermiso.AsignarHijo(padreSeleccionado, permisoNuevo);
        }

        public void CrearPermiso(BE.COMPONENTE c)
        {
            mapperPermiso.Insertar(c);
        }

        public void EliminarPermiso(BE.COMPONENTE c)
        {
            mapperPermiso.Eliminar(c);
        }

        public List<BE.COMPONENTE> ObtenerPermisosUsuario(BE.USUARIO usuario)
        {   
            
            return mapperPermiso.ObtenerPermisosUsuario(usuario);
        }

        // Método necesario para completar el árbol recursivamente
        public void LlenarHijos(COMPONENTE padre)
        {
            // Aquí llamarías a tu DAL para buscar los hijos de un padre específico
            // SELECT id_hijo FROM PERMISO_HIJO WHERE id_padre = padre.Id
            var hijos = mapperPermiso.ObtenerHijos(padre.Id);
            foreach (var hijo in hijos)
            {
                padre.Agregar(hijo);
                LlenarHijos(hijo); // Recursión para niveles profundos
            }
        }

        public List<COMPONENTE> ObtenerTodosLosPermisos()
        {
            return mapperPermiso.ObtenerTodosLosPermisos();
        }

        public List<COMPONENTE> ObtenerPermisosDeUsuario(USUARIO usuarioSeleccionado)
        {
            throw new NotImplementedException();
        }

        public void AsignarPermisoAUsuario(USUARIO usuario, COMPONENTE permisoSeleccionado)
        {
            throw new NotImplementedException();
        }

        public List<COMPONENTE> ObtenerRaicesDelUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
