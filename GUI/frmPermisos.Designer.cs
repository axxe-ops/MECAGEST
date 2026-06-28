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
            this.tvPermisosEstructurados = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.txtNombrePermiso = new System.Windows.Forms.TextBox();
            this.lblNombrePermiso = new System.Windows.Forms.Label();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.tvPermisosSinEstructurar = new System.Windows.Forms.TreeView();
            this.lblPermisosCatalogo = new System.Windows.Forms.Label();
            this.btnAsignarPermisoAUsuario = new System.Windows.Forms.Button();
            this.lblActualizarPermisosEstructurados = new System.Windows.Forms.Button();
            this.btnActualizarPermisosSinEstructurar = new System.Windows.Forms.Button();
            this.lblFlecha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvPermisosEstructurados
            // 
            this.tvPermisosEstructurados.Location = new System.Drawing.Point(3, 3);
            this.tvPermisosEstructurados.Name = "tvPermisosEstructurados";
            this.tvPermisosEstructurados.Size = new System.Drawing.Size(293, 395);
            this.tvPermisosEstructurados.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvPermisosEstructurados);
            this.panel1.Location = new System.Drawing.Point(251, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 401);
            this.panel1.TabIndex = 1;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(56, 41);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(189, 53);
            this.btnCrearRol.TabIndex = 2;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearPermiso_Click);
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
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(56, 363);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(189, 53);
            this.btnEliminarRol.TabIndex = 6;
            this.btnEliminarRol.Text = "Eliminar Rol";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tvPermisosSinEstructurar
            // 
            this.tvPermisosSinEstructurar.Location = new System.Drawing.Point(766, 41);
            this.tvPermisosSinEstructurar.Name = "tvPermisosSinEstructurar";
            this.tvPermisosSinEstructurar.Size = new System.Drawing.Size(247, 375);
            this.tvPermisosSinEstructurar.TabIndex = 7;
            // 
            // lblPermisosCatalogo
            // 
            this.lblPermisosCatalogo.AutoSize = true;
            this.lblPermisosCatalogo.Location = new System.Drawing.Point(766, 22);
            this.lblPermisosCatalogo.Name = "lblPermisosCatalogo";
            this.lblPermisosCatalogo.Size = new System.Drawing.Size(109, 13);
            this.lblPermisosCatalogo.TabIndex = 8;
            this.lblPermisosCatalogo.Text = "Catalogo de Permisos";
            // 
            // btnAsignarPermisoAUsuario
            // 
            this.btnAsignarPermisoAUsuario.Location = new System.Drawing.Point(556, 211);
            this.btnAsignarPermisoAUsuario.Name = "btnAsignarPermisoAUsuario";
            this.btnAsignarPermisoAUsuario.Size = new System.Drawing.Size(204, 51);
            this.btnAsignarPermisoAUsuario.TabIndex = 9;
            this.btnAsignarPermisoAUsuario.Text = "Asignar Permiso";
            this.btnAsignarPermisoAUsuario.UseVisualStyleBackColor = true;
            this.btnAsignarPermisoAUsuario.Click += new System.EventHandler(this.btnAsignarPermisoAUsuario_Click);
            // 
            // lblActualizarPermisosEstructurados
            // 
            this.lblActualizarPermisosEstructurados.Location = new System.Drawing.Point(472, 419);
            this.lblActualizarPermisosEstructurados.Name = "lblActualizarPermisosEstructurados";
            this.lblActualizarPermisosEstructurados.Size = new System.Drawing.Size(75, 23);
            this.lblActualizarPermisosEstructurados.TabIndex = 10;
            this.lblActualizarPermisosEstructurados.Text = "Actualizar";
            this.lblActualizarPermisosEstructurados.UseVisualStyleBackColor = true;
            this.lblActualizarPermisosEstructurados.Click += new System.EventHandler(this.lblActualizarPermisosEstructurados_Click);
            // 
            // btnActualizarPermisosSinEstructurar
            // 
            this.btnActualizarPermisosSinEstructurar.Location = new System.Drawing.Point(938, 419);
            this.btnActualizarPermisosSinEstructurar.Name = "btnActualizarPermisosSinEstructurar";
            this.btnActualizarPermisosSinEstructurar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarPermisosSinEstructurar.TabIndex = 10;
            this.btnActualizarPermisosSinEstructurar.Text = "Actualizar";
            this.btnActualizarPermisosSinEstructurar.UseVisualStyleBackColor = true;
            this.btnActualizarPermisosSinEstructurar.Click += new System.EventHandler(this.btnActualizarPermisosSinEstructurar_Click);
            // 
            // lblFlecha
            // 
            this.lblFlecha.AutoSize = true;
            this.lblFlecha.Location = new System.Drawing.Point(629, 195);
            this.lblFlecha.Name = "lblFlecha";
            this.lblFlecha.Size = new System.Drawing.Size(67, 13);
            this.lblFlecha.TabIndex = 11;
            this.lblFlecha.Text = "<------------------";
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 518);
            this.Controls.Add(this.lblFlecha);
            this.Controls.Add(this.btnActualizarPermisosSinEstructurar);
            this.Controls.Add(this.lblActualizarPermisosEstructurados);
            this.Controls.Add(this.btnAsignarPermisoAUsuario);
            this.Controls.Add(this.lblPermisosCatalogo);
            this.Controls.Add(this.tvPermisosSinEstructurar);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.lblNombrePermiso);
            this.Controls.Add(this.txtNombrePermiso);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.panel1);
            this.Name = "frmPermisos";
            this.Text = "frmPermisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPermisosEstructurados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.TextBox txtNombrePermiso;
        private System.Windows.Forms.Label lblNombrePermiso;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.TreeView tvPermisosSinEstructurar;
        private System.Windows.Forms.Label lblPermisosCatalogo;
        private System.Windows.Forms.Button btnAsignarPermisoAUsuario;
        private System.Windows.Forms.Button lblActualizarPermisosEstructurados;
        private System.Windows.Forms.Button btnActualizarPermisosSinEstructurar;
        private System.Windows.Forms.Label lblFlecha;
    }
}