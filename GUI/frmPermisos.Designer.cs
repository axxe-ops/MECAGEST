namespace GUI
{
    partial class frmPermisos
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
            this.tvPermisos = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearPermiso = new System.Windows.Forms.Button();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.lblNombrePermiso = new System.Windows.Forms.Label();
            this.lblTipoPermiso = new System.Windows.Forms.Label();
            this.cmbTipoPermiso = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tvPermisosAUsuarios = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignarPermisoAUsuario = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPermisos
            // 
            this.tvPermisos.Location = new System.Drawing.Point(3, 3);
            this.tvPermisos.Name = "tvPermisos";
            this.tvPermisos.Size = new System.Drawing.Size(293, 395);
            this.tvPermisos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvPermisos);
            this.panel1.Location = new System.Drawing.Point(251, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 401);
            this.panel1.TabIndex = 1;
            // 
            // btnCrearPermiso
            // 
            this.btnCrearPermiso.Location = new System.Drawing.Point(56, 85);
            this.btnCrearPermiso.Name = "btnCrearPermiso";
            this.btnCrearPermiso.Size = new System.Drawing.Size(189, 53);
            this.btnCrearPermiso.TabIndex = 2;
            this.btnCrearPermiso.Text = "Crear Permiso";
            this.btnCrearPermiso.UseVisualStyleBackColor = true;
            this.btnCrearPermiso.Click += new System.EventHandler(this.btnCrearPermiso_Click);
            // 
            // txtNombrePermiso
            // 
            this.txtNombrePermiso.Location = new System.Drawing.Point(56, 15);
            this.txtNombrePermiso.Name = "txtNombrePermiso";
            this.txtNombrePermiso.Size = new System.Drawing.Size(189, 20);
            this.txtNombrePermiso.TabIndex = 3;
            // 
            // lblNombrePermiso
            // 
            this.lblNombrePermiso.AutoSize = true;
            this.lblNombrePermiso.Location = new System.Drawing.Point(6, 18);
            this.lblNombrePermiso.Name = "lblNombrePermiso";
            this.lblNombrePermiso.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePermiso.TabIndex = 4;
            this.lblNombrePermiso.Text = "Nombre";
            // 
            // lblTipoPermiso
            // 
            this.lblTipoPermiso.AutoSize = true;
            this.lblTipoPermiso.Location = new System.Drawing.Point(22, 47);
            this.lblTipoPermiso.Name = "lblTipoPermiso";
            this.lblTipoPermiso.Size = new System.Drawing.Size(28, 13);
            this.lblTipoPermiso.TabIndex = 4;
            this.lblTipoPermiso.Text = "Tipo";
            // 
            // cmbTipoPermiso
            // 
            this.cmbTipoPermiso.FormattingEnabled = true;
            this.cmbTipoPermiso.Location = new System.Drawing.Point(56, 44);
            this.cmbTipoPermiso.Name = "cmbTipoPermiso";
            this.cmbTipoPermiso.Size = new System.Drawing.Size(189, 21);
            this.cmbTipoPermiso.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(100, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 53);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar Permiso";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tvPermisosAUsuarios
            // 
            this.tvPermisosAUsuarios.Location = new System.Drawing.Point(766, 41);
            this.tvPermisosAUsuarios.Name = "tvPermisosAUsuarios";
            this.tvPermisosAUsuarios.Size = new System.Drawing.Size(247, 372);
            this.tvPermisosAUsuarios.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Permisos asignados a Usuarios";
            // 
            // btnAsignarPermisoAUsuario
            // 
            this.btnAsignarPermisoAUsuario.Location = new System.Drawing.Point(570, 362);
            this.btnAsignarPermisoAUsuario.Name = "btnAsignarPermisoAUsuario";
            this.btnAsignarPermisoAUsuario.Size = new System.Drawing.Size(180, 51);
            this.btnAsignarPermisoAUsuario.TabIndex = 9;
            this.btnAsignarPermisoAUsuario.Text = "Asignar Permiso a Usuario";
            this.btnAsignarPermisoAUsuario.UseVisualStyleBackColor = true;
            this.btnAsignarPermisoAUsuario.Click += new System.EventHandler(this.btnAsignarPermisoAUsuario_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(570, 102);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(180, 21);
            this.cmbUsuarios.TabIndex = 10;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 518);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.btnAsignarPermisoAUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvPermisosAUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cmbTipoPermiso);
            this.Controls.Add(this.lblTipoPermiso);
            this.Controls.Add(this.lblNombrePermiso);
            this.Controls.Add(this.txtNombrePermiso);
            this.Controls.Add(this.btnCrearPermiso);
            this.Controls.Add(this.panel1);
            this.Name = "frmPermisos";
            this.Text = "frmPermisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPermisos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearPermiso;
        private System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.Label lblNombrePermiso;
        private System.Windows.Forms.Label lblTipoPermiso;
        private System.Windows.Forms.ComboBox cmbTipoPermiso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TreeView tvPermisosAUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignarPermisoAUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}