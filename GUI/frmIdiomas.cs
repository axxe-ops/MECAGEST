using BE;
using SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmIdiomas : Form, IObserverIdioma
    {
        IDIOMABLL gestorIdioma = new IDIOMABLL();
        TRADUCCIONBLL gestorTraduccion = new TRADUCCIONBLL();

        BE.IDIOMA idiomaSeleccionado = new BE.IDIOMA();

        public frmIdiomas()
        {
            InitializeComponent();
            IDIOMABLL.ObtenerInstanciaIdioma().Suscribir(this);

        }

        private void frmIdiomas_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            ConfigurarGrilla();
            CargarComboIdiomas();

            ActualizarIdioma();

        }




        //---------------- BOTONES ------------------------------------

        private void btnCrearIdioma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreIdioma.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el idioma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (!SEGURIDAD.TienePermiso("ALTA_IDIOMA"))
            //{
            //    MessageBox.Show("No tiene permisos para crear idiomas.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            BE.IDIOMA nuevoIdioma = new BE.IDIOMA();
            nuevoIdioma.Nombre = txtNombreIdioma.Text.Trim();

            gestorIdioma.Insertar(nuevoIdioma);

            CargarComboIdiomas();

        }

        private void btnSeleccionarIdioma_Click(object sender, EventArgs e)
        {
            if (cmbSeleccionarIdioma.SelectedItem == null) return;

            idiomaSeleccionado = (BE.IDIOMA)cmbSeleccionarIdioma.SelectedItem;

            var listaTraducciones = gestorTraduccion.ListarTraducciones(idiomaSeleccionado);

            dgvIdiomas.DataSource = null;
            dgvIdiomas.DataSource = listaTraducciones;

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvIdiomas.Rows)
            {                
                var trad = (BE.TRADUCCION)fila.DataBoundItem;

                trad.Texto = fila.Cells["Texto"].Value.ToString();

                gestorTraduccion.Modificar(trad);
            }
        }






        //---------------- CONFIGURACIONES BASICAS ------------------------------------

        public void ActualizarIdioma()
        {
            IDIOMABLL traductor = IDIOMABLL.ObtenerInstanciaIdioma();

            btnExtraerEtiquetas.Text = traductor.ObtenerTraduccion("btnExtraerEtiquetas");
            btnSeleccionarIdioma.Text = traductor.ObtenerTraduccion("btnSeleccionarIdioma");
            lblNombreIdioma.Text = traductor.ObtenerTraduccion("lblNombreIdioma");
            btnGuardarCambios.Text = traductor.ObtenerTraduccion("btnGuardarCambios");
            btnCrearIdioma.Text = traductor.ObtenerTraduccion("btnCrearIdioma");
            lblSeleccionarIdioma.Text = traductor.ObtenerTraduccion("lblSeleccionarIdioma");
        }

        private void CargarComboIdiomas()
        {
            List<BE.IDIOMA> lista = gestorIdioma.Listar();
            
            cmbSeleccionarIdioma.DataSource = null;
            cmbSeleccionarIdioma.DataSource = lista;
            cmbSeleccionarIdioma.DisplayMember = "Nombre";
            cmbSeleccionarIdioma.ValueMember = "Id";

            cmbSeleccionarIdioma.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigurarGrilla()
        {
            dgvIdiomas.AutoGenerateColumns = false;
            dgvIdiomas.Columns.Clear();

            //Columna ID (Oculta)
            dgvIdiomas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdEtiqueta",
                DataPropertyName = "EtiquetaId",
                Visible = false
            });

            //Columna Idioma (Visible)
            dgvIdiomas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Idioma",
                HeaderText = "Idioma",
                ReadOnly = true                
            });

            //Columna Etiqueta (Visible)
            dgvIdiomas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreEtiqueta",
                DataPropertyName = "EtiquetaNombre",
                HeaderText = "Etiqueta",
                ReadOnly = true
            });

            //Columna Traducción (Visible y Editable)
            dgvIdiomas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Texto",
                DataPropertyName = "Texto",
                HeaderText = "Traducción",
                ReadOnly = false
            });
        }
        private void dgvIdiomas_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvIdiomas.Columns[e.ColumnIndex].Name == "Idioma")
            {
                // IMPORTANTE: Verifica que la fila sea válida y que el DataBoundItem no sea null
                if (e.RowIndex >= 0 && dgvIdiomas.Rows[e.RowIndex].DataBoundItem != null)
                {
                    var fila = dgvIdiomas.Rows[e.RowIndex].DataBoundItem as BE.TRADUCCION;
                    if (fila != null)
                    {
                        e.Value = idiomaSeleccionado.Nombre;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dgvIdiomas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Esto evita que aparezca el cuadro de diálogo de error
            // y permite que la grilla siga funcionando normalmente.
            e.ThrowException = false;
        }

        private void btnExtraerEtiquetas_Click(object sender, EventArgs e)
        {
            var tiposFormularios = Assembly.GetExecutingAssembly().GetTypes()
                            .Where(t => t.BaseType == typeof(Form));

            foreach (var tipo in tiposFormularios)
            {
                // Instanciamos el formulario de forma temporal (invisible)
                Form frm = (Form)Activator.CreateInstance(tipo);

                Console.WriteLine($"--- Etiquetas del formulario: {frm.Name} ---");
                List<string> etiquetas = ExtraerEtiquetasDeFormulario(frm.Controls);

                foreach (var tag in etiquetas)
                {
                    Console.WriteLine($"INSERT INTO ETIQUETA (nombre) VALUES ('{tag}');");
                }
            }
        }

        private List<string> ExtraerEtiquetasDeFormulario(Control.ControlCollection controles)
        {
            List<string> listaEtiquetas = new List<string>();

            foreach (Control c in controles)
            {
                // 1. Extraer el control actual si es tipo traducible
                if (c is Label || c is Button || c is CheckBox || c is RadioButton || c is GroupBox)
                {
                    if (!string.IsNullOrEmpty(c.Name)) listaEtiquetas.Add(c.Name);
                }

                // 2. CASO ESPECIAL: MenuStrip
                if (c is MenuStrip menu)
                {
                    foreach (ToolStripMenuItem item in menu.Items)
                    {
                        ExtraerItemsMenu(item, listaEtiquetas);
                    }
                }

                // 3. CASO ESPECIAL: StatusStrip
                if (c is StatusStrip status)
                {
                    foreach (ToolStripItem item in status.Items)
                    {
                        if (!string.IsNullOrEmpty(item.Name)) listaEtiquetas.Add(item.Name);
                    }
                }

                // Recursividad normal
                if (c.HasChildren)
                {
                    listaEtiquetas.AddRange(ExtraerEtiquetasDeFormulario(c.Controls));
                }
            }
            return listaEtiquetas;
        }

        // Función auxiliar para menús desplegables (recursiva)
        private void ExtraerItemsMenu(ToolStripMenuItem item, List<string> lista)
        {
            if (!string.IsNullOrEmpty(item.Name)) lista.Add(item.Name);

            foreach (ToolStripItem subItem in item.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenu)
                {
                    ExtraerItemsMenu(subMenu, lista);
                }
            }
        }
    }
}
