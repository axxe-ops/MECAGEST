using BE;
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

namespace GUI
{
    public partial class frmUsuario : Form, IObserverIdioma
    {
        IDIOMABLL gestorIdioma = new IDIOMABLL();
        BLL.USUARIO_BLL gestorUsuario = new BLL.USUARIO_BLL();
        USUARIO_CARETAKER usuarioCaretaker = new USUARIO_CARETAKER();
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            CargarComboIdiomas();
            ActualizarIdioma();
        }




        //---------------- BOTONES ------------------------------------

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedItem == null) return;

            BE.IDIOMA nuevoIdioma = (BE.IDIOMA)cmbIdioma.SelectedItem;
            IDIOMABLL.ObtenerInstanciaIdioma().CambiarIdioma(nuevoIdioma);

            BE.USUARIO usuarioActual = SERVICE.SESSIONMANAGER.ObtenerInstancia().usuario;
            gestorUsuario.ActualizarIdiomaPreferido(usuarioActual, nuevoIdioma);

        }
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            USUARIO usuarioSeleccionado = SESSIONMANAGER.ObtenerInstancia().usuario;
            USUARIO_MEMENTO memento = usuarioSeleccionado.CrearMemento();

            string nombreActor = SESSIONMANAGER.ObtenerInstancia().usuario.Nombre;
            usuarioCaretaker.GuardarEnAuditoria(memento, usuarioSeleccionado.Id, nombreActor);

            usuarioSeleccionado.Nombre = txtNombre.Text;
            gestorUsuario.ModificarUsuario(usuarioSeleccionado);

            txtNombre.Text = "";
            ((frmMenuPrincipal)this.MdiParent).ActualizarBarraEstado();

        }

        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            // Obtenemos una referencia al formulario principal (el contenedor)
            frmMenuPrincipal menuPrincipal = this.MdiParent as frmMenuPrincipal;

            if (menuPrincipal != null)
            {
                frmAuditoria formAuditoria = new frmAuditoria();
                formAuditoria.MdiParent = menuPrincipal;
                formAuditoria.Show();
            }
        }


        //---------------- CONFIGURACIONES BASICAS ------------------------------------

        private void CargarComboIdiomas()
        {
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbIdioma.DataSource = gestorIdioma.Listar();
            cmbIdioma.DisplayMember = "Nombre";

            cmbIdioma.SelectedItem = IDIOMABLL.ObtenerInstanciaIdioma().IdiomaActual;
        }

        public void ActualizarIdioma()
        {
            IDIOMABLL traductor = IDIOMABLL.ObtenerInstanciaIdioma();
            btnVerHistorial.Text = traductor.ObtenerTraduccion("btnVerHistorial");
            btnGuardarCambios.Text = traductor.ObtenerTraduccion("btnGuardarCambios");
            lblNombreActual.Text = traductor.ObtenerTraduccion("lblNombreActual");
            lblMail.Text = traductor.ObtenerTraduccion("lblMail");
            lblPasswordNueva.Text = traductor.ObtenerTraduccion("lblPasswordNueva");
            lblColocarNombre.Text = traductor.ObtenerTraduccion("lblColocarNombre");
            btnCambiarIdioma.Text = traductor.ObtenerTraduccion("btnCambiarIdioma");
            lblElegirIdioma.Text = traductor.ObtenerTraduccion("lblElegirIdioma");
        }
    }
}
