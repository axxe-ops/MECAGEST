namespace GUI
{
    partial class frmUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblElegirIdioma = new System.Windows.Forms.Label();
            this.btnCambiarIdioma = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblColocarNombre = new System.Windows.Forms.Label();
            this.lblNombreActual = new System.Windows.Forms.Label();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblPasswordNueva = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(844, 46);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(186, 21);
            this.cmbIdioma.TabIndex = 0;
            // 
            // lblElegirIdioma
            // 
            this.lblElegirIdioma.AutoSize = true;
            this.lblElegirIdioma.Location = new System.Drawing.Point(771, 49);
            this.lblElegirIdioma.Name = "lblElegirIdioma";
            this.lblElegirIdioma.Size = new System.Drawing.Size(67, 13);
            this.lblElegirIdioma.TabIndex = 1;
            this.lblElegirIdioma.Text = "Elegir Idioma";
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.Location = new System.Drawing.Point(844, 80);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(186, 60);
            this.btnCambiarIdioma.TabIndex = 2;
            this.btnCambiarIdioma.Text = "Cambiar Idioma";
            this.btnCambiarIdioma.UseVisualStyleBackColor = true;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(215, 111);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblColocarNombre
            // 
            this.lblColocarNombre.AutoSize = true;
            this.lblColocarNombre.Location = new System.Drawing.Point(127, 114);
            this.lblColocarNombre.Name = "lblColocarNombre";
            this.lblColocarNombre.Size = new System.Drawing.Size(79, 13);
            this.lblColocarNombre.TabIndex = 4;
            this.lblColocarNombre.Text = "Nombre Nuevo";
            // 
            // lblNombreActual
            // 
            this.lblNombreActual.AutoSize = true;
            this.lblNombreActual.Location = new System.Drawing.Point(127, 80);
            this.lblNombreActual.Name = "lblNombreActual";
            this.lblNombreActual.Size = new System.Drawing.Size(110, 13);
            this.lblNombreActual.TabIndex = 5;
            this.lblNombreActual.Text = "Tu nombre actual es: ";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(140, 205);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(193, 60);
            this.btnGuardarCambios.TabIndex = 6;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblPasswordNueva
            // 
            this.lblPasswordNueva.AutoSize = true;
            this.lblPasswordNueva.Location = new System.Drawing.Point(137, 140);
            this.lblPasswordNueva.Name = "lblPasswordNueva";
            this.lblPasswordNueva.Size = new System.Drawing.Size(69, 13);
            this.lblPasswordNueva.TabIndex = 4;
            this.lblPasswordNueva.Text = "Clave Nueva";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(215, 137);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(215, 163);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(183, 20);
            this.txtMail.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(137, 166);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(61, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail Nuevo";
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Location = new System.Drawing.Point(339, 205);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(59, 60);
            this.btnVerHistorial.TabIndex = 7;
            this.btnVerHistorial.Text = "Ver Historial";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 599);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.lblNombreActual);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPasswordNueva);
            this.Controls.Add(this.lblColocarNombre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCambiarIdioma);
            this.Controls.Add(this.lblElegirIdioma);
            this.Controls.Add(this.cmbIdioma);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblElegirIdioma;
        private System.Windows.Forms.Button btnCambiarIdioma;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblColocarNombre;
        private System.Windows.Forms.Label lblNombreActual;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblPasswordNueva;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnVerHistorial;
    }
}