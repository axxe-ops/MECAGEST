using BE;
using BLL;
using SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmPermisos : Form, IObserverIdioma
    {
        public BLL.PERMISO_BLL gestorPermisos = new BLL.PERMISO_BLL();
        public BLL.USUARIO_BLL gestorUsuarios = new USUARIO_BLL();

        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            CargarArbol();                  //carga Arbol de permisos de forma estructurada
            CargarArbolCatalogoPermisos();  //carga Arbol de todos los permisos sin estructurar

            ActualizarIdioma();
        }



        //---------------- CARGA DE ARBOLES ------------------------------------
        private void CargarArbol()
        {
            tvPermisosEstructurados.Nodes.Clear();

            List<COMPONENTE> listaCompleta = gestorPermisos.ObtenerTodosLosPermisos();

            OrdenarCompuestosAscendente(listaCompleta);

            foreach (var p in listaCompleta)
            {
                if (p is BE.PermisoCompuesto && EsHijo(p.Id, listaCompleta) == false)
                {
                    TreeNode nodo = tvPermisosEstructurados.Nodes.Add(p.Id.ToString(), p.Nombre);
                    nodo.Tag = p;

                    LlenarNodosRecursivo(nodo, p);
                }
            }

            List<BE.USUARIO> usuarios = gestorUsuarios.Listar();
            foreach (var u in usuarios)
            {
                TreeNode nodoUsuario = tvPermisosEstructurados.Nodes.Add("U_" + u.Id, "👤 " + u.Nombre);
                nodoUsuario.Tag = u;


                List<COMPONENTE> roles = gestorPermisos.ObtenerRolesDeUsuario(u);

                foreach (var rol in roles)
                {

                    TreeNode nodoRol = nodoUsuario.Nodes.Add(rol.Id.ToString(), rol.Nombre);
                    nodoRol.Tag = rol;

                    LlenarNodosDesdeObjeto(nodoRol, rol);
                }
            }

            
        }
        private void LlenarNodosRecursivo(TreeNode nodoPadre, COMPONENTE componente)
        {
            if (componente is PermisoCompuesto compuesto)
            {
                foreach (var hijo in compuesto.ObtenerHijos())
                {
                    TreeNode nodoHijo = nodoPadre.Nodes.Add(hijo.Id.ToString(), hijo.Nombre);
                    nodoHijo.Tag = hijo;
                    LlenarNodosRecursivo(nodoHijo, hijo);
                }
            }
        }
        private bool EsHijo(int id, List<COMPONENTE> todos)
        {
            foreach (var permiso in todos)            {
                
                if (permiso is PermisoCompuesto)
                {
                    PermisoCompuesto compuesto = (PermisoCompuesto)permiso;

                    foreach (var hijo in compuesto.ObtenerHijos())
                    {
                        if (hijo.Id == id)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        private void LlenarNodosDesdeObjeto(TreeNode nodoPadre, COMPONENTE componente)
        {
            if (componente is BE.PermisoCompuesto compuesto)
            {
                foreach (var hijo in compuesto.ObtenerHijos())
                {
                    TreeNode nodoHijo = nodoPadre.Nodes.Add(hijo.Id.ToString(), hijo.Nombre);
                    nodoHijo.Tag = hijo;

                    LlenarNodosDesdeObjeto(nodoHijo, hijo);
                }
            }
        }
        private void CargarArbolCatalogoPermisos()
        {
            tvPermisosSinEstructurar.Nodes.Clear();
            List<BE.COMPONENTE> todos = gestorPermisos.ObtenerTodosLosPermisos();

            foreach (var p in todos)
            {
                string prefijo;

                if (p is BE.PermisoCompuesto)
                {
                    prefijo = "[ROL] ";
                }
                else
                {
                    prefijo = "";
                }

                TreeNode nodo = tvPermisosSinEstructurar.Nodes.Add(p.Id.ToString(), prefijo + p.Nombre);
                nodo.Tag = p;
            }
        }





        //---------------- BOTONES ------------------------------------
        private void btnCrearPermiso_Click(object sender, EventArgs e)
        {
            if (!SEGURIDAD.TienePermiso("ALTA_ROL"))
            {
                MessageBox.Show("No tiene permisos para crear nuevos roles.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BE.COMPONENTE permisoNuevo = new BE.PermisoCompuesto();

            string nombre = txtNombrePermiso.Text;     
            permisoNuevo.Nombre = nombre;

            gestorPermisos.CrearPermiso(permisoNuevo);
            CargarArbol();
        }

        private void btnEliminar_Click(object sender, EventArgs e) 
        {
            //Desvincular si es Simple 
            //Eliminar si es Compuesto sin hijos

            if (!SEGURIDAD.TienePermiso("ELIMINAR_ROL"))
            {
                MessageBox.Show("No tiene permisos para eliminar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tvPermisosEstructurados.SelectedNode == null) return;

            COMPONENTE seleccionado = (COMPONENTE)tvPermisosEstructurados.SelectedNode.Tag;

            if (tvPermisosEstructurados.SelectedNode.Parent != null)
            {
                // CASO 1: Es un hijo, siempre se desvincula (sea Simple o Compuesto)
                COMPONENTE padre = (COMPONENTE)tvPermisosEstructurados.SelectedNode.Parent.Tag;
                gestorPermisos.DesvincularPermiso(padre, seleccionado);
            }
            else
            {
                // CASO 2: Es un nodo raíz. Aquí validamos el tipo
                if (seleccionado is BE.PermisoSimple)
                {
                    MessageBox.Show("Los permisos simples son de sistema y no se pueden eliminar, solo desvincular de los roles.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var confirm = MessageBox.Show($"¿Desea eliminar permanentemente el Rol '{seleccionado.Nombre}'?"
                                                , "Confirmar", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        gestorPermisos.EliminarPermiso(seleccionado);
                    }
                }
            }

            CargarArbol();
        }
        private void btnAsignarPermisoAUsuario_Click(object sender, EventArgs e)
        {
            if (!SEGURIDAD.TienePermiso("ASIGNAR_ROL"))
            {
                MessageBox.Show("No tiene permisos para asignar.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //asignar de catalogo...
            if (tvPermisosSinEstructurar.SelectedNode == null) return;
            BE.COMPONENTE permisoSeleccionado = (BE.COMPONENTE)tvPermisosSinEstructurar.SelectedNode.Tag;

            //...a permiso
            if (tvPermisosEstructurados.SelectedNode == null) return;
            object destino = tvPermisosEstructurados.SelectedNode.Tag;

            if (destino is BE.PermisoCompuesto rolPadre)
            {
                // Caso A: Armamos la jerarquía de un ROL
                if (EsBucle(rolPadre, permisoSeleccionado))
                {
                    MessageBox.Show("ERROR - La asignación crearía una referencia circular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                gestorPermisos.AsignarHijo(rolPadre, permisoSeleccionado);
            }
            else if (destino is BE.USUARIO usuarioDestino)
            {
                // Caso B: Aignamos un ROL a un USUARIO
                if (permisoSeleccionado is BE.PermisoCompuesto)
                {
                    gestorPermisos.AsignarRolAUsuario(usuarioDestino, permisoSeleccionado);
                }
                else
                {
                    MessageBox.Show("A un usuario solo se le pueden asignar Roles (Permisos Compuestos).");
                    return;
                }
            }

            CargarArbol();
            CargarArbolCatalogoPermisos();
        }

        private bool EsBucle(COMPONENTE padre, COMPONENTE hijo)
        {
            if (padre.Id == hijo.Id) return true;

            if (hijo is BE.PermisoCompuesto compuesto)
            {
                foreach (var subHijo in compuesto.ObtenerHijos())
                {
                    if (EsBucle(padre, subHijo))
                        return true;
                }
            }
            return false;
        }

        private void lblActualizarPermisosEstructurados_Click(object sender, EventArgs e)
        {
            CargarArbol();
        }
        private void btnActualizarPermisosSinEstructurar_Click(object sender, EventArgs e)
        {
            CargarArbolCatalogoPermisos();
        }


        //---------------- FUNCION DECORATIVA ------------------------------------
        private void OrdenarCompuestosAscendente(List<BE.COMPONENTE> listaCompleta)
        {
            
            List<COMPONENTE> compuestos = new List<COMPONENTE>();
            List<COMPONENTE> simples = new List<COMPONENTE>();

            
            foreach (var p in listaCompleta)
            {
                if (p is BE.PermisoCompuesto)
                    compuestos.Add(p);
                else
                    simples.Add(p);
            }

            List<COMPONENTE> listaOrdenada = new List<COMPONENTE>();
            listaOrdenada.AddRange(compuestos);
            listaOrdenada.AddRange(simples);
        }

        //---------------- CONFIGURACIONES BASICAS ------------------------------------

        public void ActualizarIdioma()
        {
            IDIOMABLL traductor = IDIOMABLL.ObtenerInstanciaIdioma();
            lblFlecha.Text = traductor.ObtenerTraduccion("lblFlecha");
            btnActualizarPermisosSinEstructurar.Text = traductor.ObtenerTraduccion("btnActualizarPermisosSinEstructurar");
            lblActualizarPermisosEstructurados.Text = traductor.ObtenerTraduccion("lblActualizarPermisosEstructurados");
            btnAsignarPermisoAUsuario.Text = traductor.ObtenerTraduccion("btnAsignarPermisoAUsuario");
            lblPermisosCatalogo.Text = traductor.ObtenerTraduccion("lblPermisosCatalogo");
            btnEliminarRol.Text = traductor.ObtenerTraduccion("btnEliminarRol");
            lblNombrePermiso.Text = traductor.ObtenerTraduccion("lblNombrePermiso");
            btnCrearRol.Text = traductor.ObtenerTraduccion("btnCrearRol");
        }
    }
}
