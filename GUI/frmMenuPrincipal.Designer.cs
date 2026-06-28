namespace GUI
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblFecha_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.gestionTurnosToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.gestionAdminToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            this.menúToolStripMenuItem.Click += new System.EventHandler(this.menúToolStripMenuItem_Click);
            // 
            // gestionTurnosToolStripMenuItem
            // 
            this.gestionTurnosToolStripMenuItem.Name = "gestionTurnosToolStripMenuItem";
            this.gestionTurnosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestionTurnosToolStripMenuItem.Text = "Gestion Turnos";
            // 
            // gestionStockToolStripMenuItem
            // 
            this.gestionStockToolStripMenuItem.Name = "gestionStockToolStripMenuItem";
            this.gestionStockToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionStockToolStripMenuItem.Text = "Gestion Stock";
            // 
            // gestionAdminToolStripMenuItem
            // 
            this.gestionAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem,
            this.gestionPermisosToolStripMenuItem,
            this.gestionIdiomasToolStripMenuItem});
            this.gestionAdminToolStripMenuItem.Name = "gestionAdminToolStripMenuItem";
            this.gestionAdminToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestionAdminToolStripMenuItem.Text = "Gestion Admin";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitacoraToolStripMenuItem.Text = "Gestion Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // gestionPermisosToolStripMenuItem
            // 
            this.gestionPermisosToolStripMenuItem.Name = "gestionPermisosToolStripMenuItem";
            this.gestionPermisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionPermisosToolStripMenuItem.Text = "Gestion Permisos";
            this.gestionPermisosToolStripMenuItem.Click += new System.EventHandler(this.gestionPermisosToolStripMenuItem_Click);
            // 
            // gestionIdiomasToolStripMenuItem
            // 
            this.gestionIdiomasToolStripMenuItem.Name = "gestionIdiomasToolStripMenuItem";
            this.gestionIdiomasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionIdiomasToolStripMenuItem.Text = "Gestion Idiomas";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesiónToolStripMenuItem1
            // 
            this.cerrarSesiónToolStripMenuItem1.Name = "cerrarSesiónToolStripMenuItem1";
            this.cerrarSesiónToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem1.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblUsuarioActual,
            this.tsslblFecha_Hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslblUsuarioActual
            // 
            this.tsslblUsuarioActual.Name = "tsslblUsuarioActual";
            this.tsslblUsuarioActual.Size = new System.Drawing.Size(50, 17);
            this.tsslblUsuarioActual.Text = "Usuario:";
            // 
            // tsslblFecha_Hora
            // 
            this.tsslblFecha_Hora.Name = "tsslblFecha_Hora";
            this.tsslblFecha_Hora.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslblUsuarioActual;
        private System.Windows.Forms.ToolStripMenuItem gestionAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslblFecha_Hora;
        private System.Windows.Forms.ToolStripMenuItem gestionTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
    }
}