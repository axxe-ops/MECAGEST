using BE;
using BLL;
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
    public partial class frmPermisos : Form
    {
        public BLL.PERMISO_BLL gestorPermisos = new BLL.PERMISO_BLL();

        public frmPermisos()
        {
            InitializeComponent();
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            ComboBoxConfiguracion();

            CargarArbol();
        }


        private void CargarArbol()
        {
            tvPermisos.Nodes.Clear();

            List<COMPONENTE> listaCompleta = gestorPermisos.ObtenerTodosLosPermisos();

            foreach (var p in listaCompleta)
            {
                // Si NO es hijo de nadie, entonces es una raíz y lo dibujamos
                if (EsHijo(p.Id, listaCompleta) == false)
                {
                    TreeNode nodo = tvPermisos.Nodes.Add(p.Id.ToString(), p.Nombre);
                    nodo.Tag = p;
                                        
                    LlenarNodosRecursivo(nodo, p);
                }
            }

            tvPermisos.ExpandAll();
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
        private void btnCrearPermiso_Click(object sender, EventArgs e)
        {

            BE.COMPONENTE permisoNuevo;

            string nombre = txtNombrePermiso.Text;
            string tipo = cmbTipoPermiso.SelectedItem.ToString();

            if (tipo == "COMPUESTO")
            {
                permisoNuevo = new BE.PermisoCompuesto();
            }
            else
            {
                permisoNuevo = new PermisoSimple();
            }

            permisoNuevo.Nombre = nombre;

            gestorPermisos.CrearPermiso(permisoNuevo);

            if (tvPermisos.SelectedNode != null)
            {
                BE.COMPONENTE padreSeleccionado = (BE.COMPONENTE)tvPermisos.SelectedNode.Tag;

                if (padreSeleccionado is BE.PermisoCompuesto)
                {
                    gestorPermisos.AsignarHijo(padreSeleccionado, permisoNuevo);
                }
                else
                {
                    MessageBox.Show("El permiso seleccionado no es un contenedor (Rol). El nuevo permiso se creó de forma independiente.");
                }
            }

            CargarArbol();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tvPermisos.SelectedNode == null) return;

            COMPONENTE permisoSeleccionado = (COMPONENTE)tvPermisos.SelectedNode.Tag;

            var confirm = MessageBox.Show("¿Está seguro de eliminar este permiso? Se borrarán sus relaciones.",
                                          "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {                
                gestorPermisos.EliminarPermiso(permisoSeleccionado);
                
                CargarArbol();
            }
        }

        private void ComboBoxConfiguracion()
        {
            cmbTipoPermiso.Items.Clear();
            cmbTipoPermiso.Items.Add("SIMPLE");
            cmbTipoPermiso.Items.Add("COMPUESTO");
            
            cmbTipoPermiso.SelectedIndex = 0;
            
            cmbTipoPermiso.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BE.USUARIO usuarioSeleccionado = (BE.USUARIO)cmbUsuarios.SelectedItem;

            //CargarArbol();

            //List<COMPONENTE> asignados = gestorPermisos.ObtenerPermisosDeUsuario(usuarioSeleccionado);

            
            ////lstPermisosAsignados.DataSource = asignados;
            ////lstPermisosAsignados.DisplayMember = "Nombre";
        }

        private void btnAsignarPermisoAUsuario_Click(object sender, EventArgs e)
        {
            //if (tvPermisos.SelectedNode == null) return;

            //BE.USUARIO usuario = (BE.USUARIO)cmbUsuarios.SelectedItem;
            //COMPONENTE permisoSeleccionado = (COMPONENTE)tvPermisos.SelectedNode.Tag;

            
            //gestorPermisos.AsignarPermisoAUsuario(usuario, permisoSeleccionado);

            //// Refrescamos la lista de la derecha
            //ActualizarTreeViewAsignados(usuario);
        }

        private void ActualizarTreeViewAsignados(BE.USUARIO usuario)
        {
            //tvPermisosAUsuarios.Nodes.Clear();

            
            //List<COMPONENTE> raicesAsignadas = gestorPermisos.ObtenerRaicesDelUsuario(usuario.Id);

            //foreach (var p in raicesAsignadas)
            //{
            //    TreeNode nodo = tvPermisosAUsuarios.Nodes.Add(p.Id.ToString(), p.Nombre);
            //    nodo.Tag = p;

            //    // 2. Usamos la misma recursión para dibujar sus hijos
            //    LlenarNodosRecursivo(nodo, p);
            //}

            //tvPermisosAUsuarios.ExpandAll();
        }
    }
}
