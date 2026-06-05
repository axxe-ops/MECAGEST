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
            //List<BE.COMPONENTE> listaPermisos = gestorPermisos.ObtenerTodoElArbol();
            //CargarTreeView(listaPermisos);
        }

        // 1. Llamas a esto para iniciar el proceso
        public void CargarTreeView(List<BE.COMPONENTE> lista)
        {
            tvPermisos.Nodes.Clear();

            foreach (var comp in lista)
            {
                TreeNode nodo = new TreeNode(comp.Nombre);
                nodo.Tag = comp;                            // IMPORTANTE: Guardamos el objeto BE aquí
                tvPermisos.Nodes.Add(nodo);

                // 2. Si es compuesto, llamamos recursivamente a la función
                if (comp is BE.PermisoCompuesto compuesto)
                {
                    CargarNodosRecursivos(nodo, compuesto.ObtenerPermisos());
                }
            }
        }


        // 3. Esta es la función recursiva que recorre el árbol
        private void CargarNodosRecursivos(TreeNode nodoPadre, List<BE.COMPONENTE> listaHijos)
        {
            foreach (var hijo in listaHijos)
            {
                TreeNode nodoHijo = new TreeNode(hijo.Nombre);
                nodoHijo.Tag = hijo;
                nodoPadre.Nodes.Add(nodoHijo);

                // Si el hijo también es compuesto, seguimos bajando
                if (hijo is BE.PermisoCompuesto compuesto)
                {
                    CargarNodosRecursivos(nodoHijo, compuesto.ObtenerPermisos());
                }
            }
        }


    }
}
