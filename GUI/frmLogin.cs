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
    public partial class frmLogin : Form
    {
        BLL.USUARIO_BLL gestorUsuario = new BLL.USUARIO_BLL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true; //contraseñatxt oculta predeterminadamente
            WindowState = FormWindowState.Maximized;
        }
        
        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                lblResultado.Text = "*Por favor, complete ambos campos.";
                lblResultado.ForeColor = Color.DarkRed;
                return;
            }
            
            BE.USUARIO usuario = new BE.USUARIO();
            usuario.Nombre = txtNombre.Text;
            usuario.Contrasena = txtContraseña.Text;

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
    }
}
