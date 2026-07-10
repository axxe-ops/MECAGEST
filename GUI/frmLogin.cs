using BE;
using SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private BLL.USUARIO_BLL gestorUsuario = new BLL.USUARIO_BLL();
        private SERVICE.VERIFICARDIGITOS_BLL gestorIntegridad = new VERIFICARDIGITOS_BLL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            txtContraseña.UseSystemPasswordChar = true; //contraseñatxt oculta predeterminadamente
            WindowState = FormWindowState.Maximized;

            lblParaProfe.Text =" Usuario: axel \n Contraseña: 1234 \n\n Usuario: lauti \n Contraseña: 1000";

        }





        //---------------- BOTONES ------------------------------------
        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                VerificarIntegridad();

                string nombre = txtNombre.Text;
                string contrasena = txtContraseña.Text;

                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    lblResultado.Text = "*Por favor, complete ambos campos.";
                    lblResultado.ForeColor = Color.DarkRed;
                    return;
                }

                BE.USUARIO usuario = new BE.USUARIO();
                usuario.Nombre = nombre;
                usuario.Contrasena = contrasena;

                bool exito = SERVICE.SESSIONMANAGER.Login(usuario);

                if (exito)
                {
                    SERVICE.BITACORABLL.Registrar(
                        "Inicio de sesión exitoso",                                 //evento
                        "El usuario ha ingresado al sistema desde la IP local.",    //detalle
                        1                                                           // Criticidad Baja: evento rutinario
                    );

                    this.Hide();
                    frmMenuPrincipal form = new frmMenuPrincipal();
                    form.Show();
                }
                else
                {
                    SERVICE.BITACORABLL.Registrar(
                        "Intento de inicio de sesión fallido",
                        $"El usuario intentó acceder sin éxito.",
                        3
                    );

                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }

            }
            catch (Exception ex)
            {
                string nombre = txtNombre.Text;
                string contrasena = txtContraseña.Text;

                BE.USUARIO usuario = new BE.USUARIO { Nombre = nombre, Contrasena = contrasena };
                bool esAdmin = SERVICE.SESSIONMANAGER.Login(usuario);

                if (esAdmin && SEGURIDAD.TienePermiso("ACCESO_MODO_EMERGENCIA_DIGITOS"))
                {
                    this.Hide();
                    frmMenuPrincipal form = new frmMenuPrincipal();
                    form.Show();
                    MessageBox.Show("Modo de Emergencia: Se detectó error, pero se permite acceso al Admin.");
                }

                if (ex.Message.Contains("integridad") || ex.Message.Contains("DVV") || ex.Message.Contains("DVH"))
                {//Error de inconsistencias Digitos

                    lblErrorSeguridad.Text = "ADVERTENCIA: Inconsistencia en la seguridad de los datos. El acceso ha sido bloqueado.";
                }
                else
                {//Error de base de datos u otros

                    lblErrorSeguridad.Text = "ERROR: No es posible conectar con el servidor de seguridad. Intente más tarde.";
                }

                lblErrorSeguridad.ForeColor = Color.Red;
                lblErrorSeguridad.Visible = true;

                // IMPORTANTE: Registrar el error técnico en la bitácora para que TÚ lo puedas leer luego
                SERVICE.BITACORABLL.Registrar(
                    "Error de Seguridad Crítico",
                    "Detalle técnico: " + ex.Message,
                    5 // Criticidad máxima
                );
                    
                
            }
        }

        private void btnMostrar_Ocultar_Click(object sender, EventArgs e)
        {
            // Si la contraseña está oculta (es true), la mostramos (false)
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;                
            }
            else
            {
                // Si ya se ve, la volvemos a ocultar
                txtContraseña.UseSystemPasswordChar = true;               

            }
        }


        //---------------- Digitos Verificadores ------------------------------------
        private void VerificarIntegridad()
        {
            List<USUARIO> lista = gestorUsuario.Listar();
            List<IVerificarDigitos> listaVerificable = lista.Cast<IVerificarDigitos>().ToList();

            List<string> errores = gestorIntegridad.VerificarIntegridad(listaVerificable, "USUARIO");

            if (errores.Count > 0)
            {
                throw new Exception(errores[0]);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
