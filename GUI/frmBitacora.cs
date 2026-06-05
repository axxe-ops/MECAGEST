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
    public partial class frmBitacora : Form
    {
        SERVICE.BITACORABLL gestorBitacora = new SERVICE.BITACORABLL();

        public frmBitacora()
        {
            InitializeComponent();
        }
        private void frmBitacora_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Now.AddDays(-7);
            dtpHasta.Value = DateTime.Now;

            dgvBitacora.DataSource = null;

            ConfigurarComboBoxCriticidad();

        }

        void ConfigurarComboBoxCriticidad()
        {
            var fuente = new List<object>
            {
                new { Text = "Todos", Value = 0 },
                new { Text = "Bajo", Value = 1 },
                new { Text = "Medio", Value = 3 },
                new { Text = "Crítico", Value = 5 }
            };

            cmbCriticidad.DataSource = fuente;
            cmbCriticidad.DisplayMember = "Text"; // Esto es lo que el usuario ve
            cmbCriticidad.ValueMember = "Value";  // Esto es lo que usas en el código
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarBitacora();
        }

        private void ActualizarBitacora()
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || cmbCriticidad.SelectedValue == null)
            {
                MessageBox.Show("Por favor, complete todos los campos para realizar la búsqueda.",
                                "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha <Desde> no puede ser mayor a la fecha <Hasta>.",
                                "Error en fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usuarioFiltro = txtNombreUsuario.Text.Trim();
            int criticidadFiltro = (int)cmbCriticidad.SelectedValue;
            
            var lista = gestorBitacora.Consultar(dtpDesde.Value, dtpHasta.Value, usuarioFiltro, criticidadFiltro);
            
            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = lista;
        }

    }
}
