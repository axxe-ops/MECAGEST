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
    public partial class frmMenuPrincipal : Form, IObserverIdioma
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            tsslblUsuarioActual.Text = "Usuario: " + SERVICE.SESSIONMANAGER.ObtenerInstancia().usuario.ToString();
            tsslblFecha_Hora.Text = " - Fecha: " + DateTime.Today.ToString("dd/MM/yyyy");

            
            IDIOMABLL.ObtenerInstanciaIdioma().Suscribir(this);
            //ActualizarIdioma();

        }



        //---------------- BOTONES ------------------------------------
        
        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        { // Menu
            foreach (Form frm in this.MdiChildren.ToList())
            {
                frm.Close();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        

        private void cerrarSesiónToolStripMenuItem1_Click(object sender, EventArgs e)
        { //Cerrar Sesion           
            if (MessageBox.Show("Usuario: " + SERVICE.SESSIONMANAGER.ObtenerInstancia().usuario + " - ¿Está seguro que desea cerrar sesión?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SERVICE.BITACORABLL.Registrar(
                    "Cierre de sesión",
                    $"El usuario ha finalizado su sesión de trabajo correctamente.",
                    1
                );

                bool exito = SERVICE.SESSIONMANAGER.ObtenerInstancia().Logout();

                if (exito)
                {
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();
                }
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { // Salir
            if (MessageBox.Show("¿Está seguro que deseas salir de la aplicación?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SERVICE.BITACORABLL.Registrar(
                     "Salida del sistema",
                     $"El usuario ha salido del sistema correctamente y se ha cerrado la sesión automáticamente",
                     1
                );

                SERVICE.SESSIONMANAGER.ObtenerInstancia().Logout();

                Application.Exit();
            }
        }

        //---------------- IDIOMA OBSERVER ------------------------------------
        public void ActualizarIdioma()
        {
            //ejemplo
            //lblUsuario.Text = IdiomaManager.GetInstance().ObtenerTraduccion("lbl_usuario");
            //btnAceptar.Text = IdiomaManager.GetInstance().ObtenerTraduccion("btn_aceptar");
            // new NotImplementedException();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            IDIOMABLL.ObtenerInstanciaIdioma().Desuscribir(this);
        }

        public void ActualizarBarraEstado()
        {
            var usuario = SERVICE.SESSIONMANAGER.ObtenerInstancia().usuario;
            tsslblUsuarioActual.Text = "Usuario: " + usuario.ToString();
        }

        private void gestiónBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gestion Bitacora
            if (SEGURIDAD.TienePermiso("ACCESO_GESTION_BITACORA"))
            {
                frmBitacora frm = new frmBitacora();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("No tenés permiso para ver la bitácora del sistema.", "Acceso Denegado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void seguridadToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //seguridad
            frmSeguridad frm = new frmSeguridad();
            frm.MdiParent = this;
            frm.Show();
        }

        private void auditoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //auditoria
            if (SEGURIDAD.TienePermiso("ACCESO_AUDITORIA"))
            {
                frmAuditoria frm = new frmAuditoria();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("No tenés permiso para ver la auditoria del sistema.", "Acceso Denegado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gestionPermisosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Gestion Permisos
            if (SEGURIDAD.TienePermiso("ACCESO_GESTION_PERMISO"))
            {
                frmPermisos frm = new frmPermisos();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("No tenés permiso para acceder a esta sección.", "Acceso Denegado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gestionIdiomasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Gestion Idiomas
            frmIdiomas frm = new frmIdiomas();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
