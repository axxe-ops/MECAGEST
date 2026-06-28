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

        public void DesvincularPermiso(COMPONENTE padre, COMPONENTE seleccionado)
        {
            mapperPermiso.DesvincularPermiso(padre, seleccionado);
        }

        public void AsignarRolAUsuario(USUARIO usuarioDestino, COMPONENTE permisoSeleccionado)
        {
            mapperPermiso.AsignarRolAUsuario(usuarioDestino, permisoSeleccionado);
        }

        public List<COMPONENTE> ObtenerRolesDeUsuario(USUARIO u)
        {
            // 1. Obtenemos los roles "raíz" asignados al usuario desde la DAL
            List<COMPONENTE> roles = mapperPermiso.ObtenerRolesDeUsuario(u);

            // 2. Hidratamos cada rol (cargamos sus hijos en memoria)
            foreach (var c in roles)
            {
                if (c is PermisoCompuesto compuesto)
                {
                    // Completamos la jerarquía llamando a la lógica de carga de hijos
                    CargarHijosRecursivo(compuesto);
                }
            }
            return roles;
        }

        private void CargarHijosRecursivo(PermisoCompuesto padre)
        {
            // Buscamos los hijos directos de este compuesto
            List<COMPONENTE> hijos = mapperPermiso.ObtenerHijosDePermiso(padre.Id);

            foreach (var hijo in hijos)
            {
                padre.Agregar(hijo);

                // Si el hijo es compuesto, seguimos bajando
                if (hijo is PermisoCompuesto hijoCompuesto)
                {
                    CargarHijosRecursivo(hijoCompuesto);
                }
            }
        }
    }
}
