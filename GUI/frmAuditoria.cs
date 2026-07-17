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

namespace GUI
{
    public partial class frmAuditoria : Form, IObserverIdioma
    {
        SERVICE.AUDITORIA gestorAuditoria = new SERVICE.AUDITORIA();
        USUARIO_BLL gestorUsuario = new USUARIO_BLL();

        public frmAuditoria()
        {            
            InitializeComponent();
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {   
            USUARIO usuario = SESSIONMANAGER.ObtenerInstancia().usuario;

            if (SEGURIDAD.TienePermiso("PERMISO_AUDITORIA_HISTORIAL_COMO_ADMIN"))
            {// MODO ADMIN: Ve todo y tiene permiso para revertir

                dgvHistorial.DataSource = gestorAuditoria.ObtenerHistorial();
                btnVolverAtras.Enabled = true;
            }
            else
            {// MODO USUARIO: Solo ve lo suyo y NO puede revertir

                dgvHistorial.DataSource = gestorAuditoria.ObtenerHistorial(usuario.Id);
                btnVolverAtras.Enabled = false;
            }

            ConfigurarDgvHistorial();
            ActualizarIdioma();
            WindowState = FormWindowState.Maximized;

        }

        //---------------- BOTONES ------------------------------------

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {

            if (dgvHistorial.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para restaurar.");
                return;
            }

            try
            {
                DataGridViewRow fila = dgvHistorial.SelectedRows[0];
                int idUsuarioAfectado = Convert.ToInt32(fila.Cells["id_entidad"].Value);
                string valorAnterior = fila.Cells["valor_anterior"].Value.ToString();

                USUARIO usuarioAModificar = gestorUsuario.ObtenerUsuarioPorId(idUsuarioAfectado);

                USUARIO_MEMENTO memento = new USUARIO_MEMENTO(valorAnterior);
                usuarioAModificar.Restaurar(memento);

                gestorUsuario.ModificarUsuario(usuarioAModificar);

                var usuarioActual = SERVICE.SESSIONMANAGER.ObtenerInstancia().usuario;
                if (usuarioActual.Id == usuarioAModificar.Id)
                {
                    usuarioActual.Nombre = usuarioAModificar.Nombre;
                }

                ActualizarToolStripSesion();               
                frmAuditoria_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar: " + ex.Message);
            }

        }


        //---------------- CONFIGURACIONES BASICAS ------------------------------------

        //observer
        public void ActualizarIdioma()
        {
            IDIOMABLL traductor = IDIOMABLL.ObtenerInstanciaIdioma();
            btnCerrar.Text = traductor.ObtenerTraduccion("btnCerrar");
            btnVolverAtras.Text = traductor.ObtenerTraduccion("btnVolverAtras");
        }

        private void ConfigurarDgvHistorial()
        {
            dgvHistorial.Columns["valor_anterior"].HeaderText = "Valor Histórico";
            dgvHistorial.Columns["usuario_editor"].HeaderText = "Editado por";
            dgvHistorial.Columns["fecha_cambio"].HeaderText = "Fecha y Hora";
            if (dgvHistorial.Columns.Contains("UsuarioAfectado"))
            {
                dgvHistorial.Columns["UsuarioAfectado"].HeaderText = "Usuario (Entidad)";
            }

            dgvHistorial.Columns["id"].Visible = false;
            dgvHistorial.Columns["id_entidad"].Visible = false;
        }
        private void ActualizarToolStripSesion()
        {
            var menu = this.MdiParent as frmMenuPrincipal;
            if (menu != null)
            {
                menu.ActualizarBarraEstado();
            }
        }
    }
}
