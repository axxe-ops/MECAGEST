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
            this.SuspendLayout();
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(287, 115);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(186, 21);
            this.cmbIdioma.TabIndex = 0;
            // 
            // lblElegirIdioma
            // 
            this.lblElegirIdioma.AutoSize = true;
            this.lblElegirIdioma.Location = new System.Drawing.Point(214, 118);
            this.lblElegirIdioma.Name = "lblElegirIdioma";
            this.lblElegirIdioma.Size = new System.Drawing.Size(67, 13);
            this.lblElegirIdioma.TabIndex = 1;
            this.lblElegirIdioma.Text = "Elegir Idioma";
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.Location = new System.Drawing.Point(287, 162);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(186, 50);
            this.btnCambiarIdioma.TabIndex = 2;
            this.btnCambiarIdioma.Text = "Cambiar Idioma";
            this.btnCambiarIdioma.UseVisualStyleBackColor = true;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}