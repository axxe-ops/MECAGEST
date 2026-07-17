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
    public partial class frmSeguridad : Form, IObserverIdioma
    {
        BLL.USUARIO_BLL gestorUsuario = new BLL.USUARIO_BLL();
        SERVICE.VERIFICARDIGITOS_BLL gestorIntegridad = new SERVICE.VERIFICARDIGITOS_BLL();

        public frmSeguridad()
        {
            InitializeComponent();
        }

        private void frmSeguridad_Load(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }


        //---------------- BOTONES ------------------------------------
        private void btnRecalcularDigitosVerificadores_Click(object sender, EventArgs e)
        {
            List<USUARIO> listaUsuarios = gestorUsuario.Listar();
            List<IVerificarDigitos> listaVerificable = listaUsuarios.Cast<IVerificarDigitos>().ToList();

            List<string> errores = gestorIntegridad.VerificarIntegridad(listaVerificable, "USUARIO");

            if (errores.Count == 0)
            {
                MessageBox.Show("El sistema ya se encuentra íntegro. No hay datos que recalcular.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Para cada usuario, recalculamos y guardamos el nuevo DVH
            foreach (var usuario in listaUsuarios)
            {
                usuario.Dvh = int.Parse(usuario.CalcularDVH());
                gestorUsuario.ActualizarDVH(usuario);
            }

            // 2. Recalcular DVV global
            int nuevoDVV = 0;
            foreach (var usuario in listaUsuarios)
            {
                if (usuario.Dvh != 0)
                {
                    nuevoDVV += usuario.Dvh;
                }
            }
            gestorIntegridad.GuardarDVV("USUARIO", nuevoDVV);
        }

        private void btnVerificarIntegridad_Click(object sender, EventArgs e)
        {
            try
            {
                List<USUARIO> listaUsuarios = gestorUsuario.Listar();                                
                List<IVerificarDigitos> listaVerificable = listaUsuarios.Cast<IVerificarDigitos>().ToList();

                List<string> errores = gestorIntegridad.VerificarIntegridad(listaVerificable, "USUARIO");

                if (errores.Count == 0)
                {
                    lblNotificacionBD.Text = "OK";
                    lblNotificacionBD.ForeColor = Color.DarkGreen;
                    dgvIntegridad.DataSource = null;
                }
                else
                {
                    lblNotificacionBD.Text = "ERROR DETECTADO";
                    lblNotificacionBD.ForeColor = Color.Red;
                    //lleno la grilla
                    dgvIntegridad.DataSource = errores.Select(x => new { Detalle = x }).ToList();
                }
            }
            catch (Exception ex)
            {
                lblNotificacionBD.Text = "ERROR - ALERTA DE SEGURIDAD";
                lblNotificacionBD.ForeColor = System.Drawing.Color.Red;

                MessageBox.Show(ex.Message, "Error de Integridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //---------------- CONFIGURACIONES BASICAS ------------------------------------
        
        //observer
        public void ActualizarIdioma()
        {
            IDIOMABLL traductor = IDIOMABLL.ObtenerInstanciaIdioma();
            lblNotificacionBD.Text = traductor.ObtenerTraduccion("lblNotificacionBD");
            lblTituloEstadoIntegridad.Text = traductor.ObtenerTraduccion("lblTituloEstadoIntegridad");
            btnRecalcularDigitosVerificadores.Text = traductor.ObtenerTraduccion("btnRecalcularDigitosVerificadores");
            btnVerificarIntegridad.Text = traductor.ObtenerTraduccion("btnVerificarIntegridad");
        }
    }
}
