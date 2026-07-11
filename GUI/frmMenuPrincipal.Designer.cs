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
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslblUsuarioActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslblFecha_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.gestionServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPermisosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionIdiomasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarTurnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.gestionTurnosToolStripMenuItem,
            this.gestionServiciosToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.seguridadToolStripMenuItem1,
            this.configuracionToolStripMenuItem});
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
            this.gestionTurnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarTurnoToolStripMenuItem,
            this.agendaToolStripMenuItem});
            this.gestionTurnosToolStripMenuItem.Name = "gestionTurnosToolStripMenuItem";
            this.gestionTurnosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.gestionTurnosToolStripMenuItem.Text = "Gestion Turnos";
            // 
            // gestionStockToolStripMenuItem
            // 
            this.gestionStockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repuestosToolStripMenuItem});
            this.gestionStockToolStripMenuItem.Name = "gestionStockToolStripMenuItem";
            this.gestionStockToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.gestionStockToolStripMenuItem.Text = "Gestion Stock";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.toolStripSeparator1,
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
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
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
            // gestionServiciosToolStripMenuItem
            // 
            this.gestionServiciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeTrabajoToolStripMenuItem});
            this.gestionServiciosToolStripMenuItem.Name = "gestionServiciosToolStripMenuItem";
            this.gestionServiciosToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.gestionServiciosToolStripMenuItem.Text = "Gestion Servicios";
            // 
            // seguridadToolStripMenuItem1
            // 
            this.seguridadToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónBitacoraToolStripMenuItem,
            this.seguridadToolStripMenuItem2,
            this.auditoriaToolStripMenuItem1});
            this.seguridadToolStripMenuItem1.Name = "seguridadToolStripMenuItem1";
            this.seguridadToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem1.Text = "Seguridad";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionPermisosToolStripMenuItem1,
            this.gestionIdiomasToolStripMenuItem1});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // gestiónBitacoraToolStripMenuItem
            // 
            this.gestiónBitacoraToolStripMenuItem.Name = "gestiónBitacoraToolStripMenuItem";
            this.gestiónBitacoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestiónBitacoraToolStripMenuItem.Text = "Gestión Bitacora";
            this.gestiónBitacoraToolStripMenuItem.Click += new System.EventHandler(this.gestiónBitacoraToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem2
            // 
            this.seguridadToolStripMenuItem2.Name = "seguridadToolStripMenuItem2";
            this.seguridadToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.seguridadToolStripMenuItem2.Text = "Gestión Seguridad";
            this.seguridadToolStripMenuItem2.Click += new System.EventHandler(this.seguridadToolStripMenuItem2_Click);
            // 
            // auditoriaToolStripMenuItem1
            // 
            this.auditoriaToolStripMenuItem1.Name = "auditoriaToolStripMenuItem1";
            this.auditoriaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.auditoriaToolStripMenuItem1.Text = "Auditoria";
            this.auditoriaToolStripMenuItem1.Click += new System.EventHandler(this.auditoriaToolStripMenuItem1_Click);
            // 
            // gestionPermisosToolStripMenuItem1
            // 
            this.gestionPermisosToolStripMenuItem1.Name = "gestionPermisosToolStripMenuItem1";
            this.gestionPermisosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gestionPermisosToolStripMenuItem1.Text = "Gestion Permisos";
            this.gestionPermisosToolStripMenuItem1.Click += new System.EventHandler(this.gestionPermisosToolStripMenuItem1_Click);
            // 
            // gestionIdiomasToolStripMenuItem1
            // 
            this.gestionIdiomasToolStripMenuItem1.Name = "gestionIdiomasToolStripMenuItem1";
            this.gestionIdiomasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gestionIdiomasToolStripMenuItem1.Text = "Gestion Idiomas";
            this.gestionIdiomasToolStripMenuItem1.Click += new System.EventHandler(this.gestionIdiomasToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Ordenes de Trabajo";
            // 
            // repuestosToolStripMenuItem
            // 
            this.repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            this.repuestosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repuestosToolStripMenuItem.Text = "Repuestos";
            // 
            // reservarTurnoToolStripMenuItem
            // 
            this.reservarTurnoToolStripMenuItem.Name = "reservarTurnoToolStripMenuItem";
            this.reservarTurnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservarTurnoToolStripMenuItem.Text = "Reservar Turno";
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
        private System.Windows.Forms.ToolStripStatusLabel tsslblFecha_Hora;
        private System.Windows.Forms.ToolStripMenuItem gestionTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónBitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionPermisosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionIdiomasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reservarTurnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repuestosToolStripMenuItem;
    }
}