namespace GUI
{
    partial class frmSeguridad
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
            this.dgvIntegridad = new System.Windows.Forms.DataGridView();
            this.btnVerificarIntegridad = new System.Windows.Forms.Button();
            this.btnRecalcularDigitosVerificadores = new System.Windows.Forms.Button();
            this.lblTituloEstadoIntegridad = new System.Windows.Forms.Label();
            this.lblNotificacionBD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegridad)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIntegridad
            // 
            this.dgvIntegridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegridad.Location = new System.Drawing.Point(127, 135);
            this.dgvIntegridad.Name = "dgvIntegridad";
            this.dgvIntegridad.Size = new System.Drawing.Size(880, 428);
            this.dgvIntegridad.TabIndex = 0;
            // 
            // btnVerificarIntegridad
            // 
            this.btnVerificarIntegridad.Location = new System.Drawing.Point(125, 569);
            this.btnVerificarIntegridad.Name = "btnVerificarIntegridad";
            this.btnVerificarIntegridad.Size = new System.Drawing.Size(161, 56);
            this.btnVerificarIntegridad.TabIndex = 1;
            this.btnVerificarIntegridad.Text = "Verificar Integridad";
            this.btnVerificarIntegridad.UseVisualStyleBackColor = true;
            this.btnVerificarIntegridad.Click += new System.EventHandler(this.btnVerificarIntegridad_Click);
            // 
            // btnRecalcularDigitosVerificadores
            // 
            this.btnRecalcularDigitosVerificadores.Location = new System.Drawing.Point(292, 569);
            this.btnRecalcularDigitosVerificadores.Name = "btnRecalcularDigitosVerificadores";
            this.btnRecalcularDigitosVerificadores.Size = new System.Drawing.Size(161, 56);
            this.btnRecalcularDigitosVerificadores.TabIndex = 2;
            this.btnRecalcularDigitosVerificadores.Text = "Recalcular Digitos Verificadores";
            this.btnRecalcularDigitosVerificadores.UseVisualStyleBackColor = true;
            this.btnRecalcularDigitosVerificadores.Click += new System.EventHandler(this.btnRecalcularDigitosVerificadores_Click);
            // 
            // lblTituloEstadoIntegridad
            // 
            this.lblTituloEstadoIntegridad.AutoSize = true;
            this.lblTituloEstadoIntegridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEstadoIntegridad.Location = new System.Drawing.Point(127, 90);
            this.lblTituloEstadoIntegridad.Name = "lblTituloEstadoIntegridad";
            this.lblTituloEstadoIntegridad.Size = new System.Drawing.Size(416, 25);
            this.lblTituloEstadoIntegridad.TabIndex = 3;
            this.lblTituloEstadoIntegridad.Text = "Estado de Integridad de la Base de Datos:";
            // 
            // lblNotificacionBD
            // 
            this.lblNotificacionBD.AutoSize = true;
            this.lblNotificacionBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacionBD.Location = new System.Drawing.Point(549, 90);
            this.lblNotificacionBD.Name = "lblNotificacionBD";
            this.lblNotificacionBD.Size = new System.Drawing.Size(0, 25);
            this.lblNotificacionBD.TabIndex = 3;
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 675);
            this.Controls.Add(this.lblNotificacionBD);
            this.Controls.Add(this.lblTituloEstadoIntegridad);
            this.Controls.Add(this.btnRecalcularDigitosVerificadores);
            this.Controls.Add(this.btnVerificarIntegridad);
            this.Controls.Add(this.dgvIntegridad);
            this.Name = "frmSeguridad";
            this.Text = "frmSeguridad";
            this.Load += new System.EventHandler(this.frmSeguridad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIntegridad;
        private System.Windows.Forms.Button btnVerificarIntegridad;
        private System.Windows.Forms.Button btnRecalcularDigitosVerificadores;
        private System.Windows.Forms.Label lblTituloEstadoIntegridad;
        private System.Windows.Forms.Label lblNotificacionBD;
    }
}