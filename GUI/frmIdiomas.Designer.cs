namespace GUI
{
    partial class frmIdiomas
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
            this.cmbSeleccionarIdioma = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarIdioma = new System.Windows.Forms.Label();
            this.btnCrearIdioma = new System.Windows.Forms.Button();
            this.lblNombreIdioma = new System.Windows.Forms.Label();
            this.txtNombreIdioma = new System.Windows.Forms.TextBox();
            this.dgvIdiomas = new System.Windows.Forms.DataGridView();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnSeleccionarIdioma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSeleccionarIdioma
            // 
            this.cmbSeleccionarIdioma.FormattingEnabled = true;
            this.cmbSeleccionarIdioma.Location = new System.Drawing.Point(177, 12);
            this.cmbSeleccionarIdioma.Name = "cmbSeleccionarIdioma";
            this.cmbSeleccionarIdioma.Size = new System.Drawing.Size(212, 21);
            this.cmbSeleccionarIdioma.TabIndex = 0;
            // 
            // lblSeleccionarIdioma
            // 
            this.lblSeleccionarIdioma.AutoSize = true;
            this.lblSeleccionarIdioma.Location = new System.Drawing.Point(74, 15);
            this.lblSeleccionarIdioma.Name = "lblSeleccionarIdioma";
            this.lblSeleccionarIdioma.Size = new System.Drawing.Size(97, 13);
            this.lblSeleccionarIdioma.TabIndex = 1;
            this.lblSeleccionarIdioma.Text = "Seleccionar Idioma";
            // 
            // btnCrearIdioma
            // 
            this.btnCrearIdioma.Location = new System.Drawing.Point(690, 58);
            this.btnCrearIdioma.Name = "btnCrearIdioma";
            this.btnCrearIdioma.Size = new System.Drawing.Size(168, 55);
            this.btnCrearIdioma.TabIndex = 2;
            this.btnCrearIdioma.Text = "Crear Idioma";
            this.btnCrearIdioma.UseVisualStyleBackColor = true;
            this.btnCrearIdioma.Click += new System.EventHandler(this.btnCrearIdioma_Click);
            // 
            // lblNombreIdioma
            // 
            this.lblNombreIdioma.AutoSize = true;
            this.lblNombreIdioma.Location = new System.Drawing.Point(572, 15);
            this.lblNombreIdioma.Name = "lblNombreIdioma";
            this.lblNombreIdioma.Size = new System.Drawing.Size(93, 13);
            this.lblNombreIdioma.TabIndex = 3;
            this.lblNombreIdioma.Text = "Nombre de Idioma";
            // 
            // txtNombreIdioma
            // 
            this.txtNombreIdioma.Location = new System.Drawing.Point(671, 12);
            this.txtNombreIdioma.Name = "txtNombreIdioma";
            this.txtNombreIdioma.Size = new System.Drawing.Size(212, 20);
            this.txtNombreIdioma.TabIndex = 4;
            // 
            // dgvIdiomas
            // 
            this.dgvIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdiomas.Location = new System.Drawing.Point(12, 58);
            this.dgvIdiomas.Name = "dgvIdiomas";
            this.dgvIdiomas.Size = new System.Drawing.Size(540, 561);
            this.dgvIdiomas.TabIndex = 5;
            this.dgvIdiomas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIdiomas_CellFormatting_1);
            this.dgvIdiomas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvIdiomas_DataError);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(167, 625);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(168, 55);
            this.btnGuardarCambios.TabIndex = 2;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnSeleccionarIdioma
            // 
            this.btnSeleccionarIdioma.Location = new System.Drawing.Point(395, 6);
            this.btnSeleccionarIdioma.Name = "btnSeleccionarIdioma";
            this.btnSeleccionarIdioma.Size = new System.Drawing.Size(107, 31);
            this.btnSeleccionarIdioma.TabIndex = 6;
            this.btnSeleccionarIdioma.Text = "Seleccionar ";
            this.btnSeleccionarIdioma.UseVisualStyleBackColor = true;
            this.btnSeleccionarIdioma.Click += new System.EventHandler(this.btnSeleccionarIdioma_Click);
            // 
            // frmIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 690);
            this.Controls.Add(this.btnSeleccionarIdioma);
            this.Controls.Add(this.dgvIdiomas);
            this.Controls.Add(this.txtNombreIdioma);
            this.Controls.Add(this.lblNombreIdioma);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnCrearIdioma);
            this.Controls.Add(this.lblSeleccionarIdioma);
            this.Controls.Add(this.cmbSeleccionarIdioma);
            this.Name = "frmIdiomas";
            this.Text = "frmIdiomas";
            this.Load += new System.EventHandler(this.frmIdiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdiomas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSeleccionarIdioma;
        private System.Windows.Forms.Label lblSeleccionarIdioma;
        private System.Windows.Forms.Button btnCrearIdioma;
        private System.Windows.Forms.Label lblNombreIdioma;
        private System.Windows.Forms.TextBox txtNombreIdioma;
        private System.Windows.Forms.DataGridView dgvIdiomas;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnSeleccionarIdioma;
    }
}