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
    public partial class frmUsuario : Form
    {
        IDIOMABLL gestorIdioma = new IDIOMABLL();
        BLL.USUARIO_BLL gestorUsuario = new BLL.USUARIO_BLL();
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CargarComboIdiomas();
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




        //---------------- CONFIGURACIONES BASICAS ------------------------------------

        private void CargarComboIdiomas()
        {
            cmbIdioma.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbIdioma.DataSource = gestorIdioma.Listar();
            cmbIdioma.DisplayMember = "Nombre";

            cmbIdioma.SelectedItem = IDIOMABLL.ObtenerInstanciaIdioma().IdiomaActual;
        }

        
    }
}
