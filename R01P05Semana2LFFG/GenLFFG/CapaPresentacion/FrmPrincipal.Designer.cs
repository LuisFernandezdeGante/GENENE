namespace CapaPresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.camionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionarCamiones = new System.Windows.Forms.ToolStripMenuItem();
            this.choferesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionarChoferes = new System.Windows.Forms.ToolStripMenuItem();
            this.rutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestionarRutas = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.HotPink;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camionesToolStripMenuItem,
            this.choferesToolStripMenuItem,
            this.rutasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // camionesToolStripMenuItem
            // 
            this.camionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestionarCamiones});
            this.camionesToolStripMenuItem.Name = "camionesToolStripMenuItem";
            this.camionesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.camionesToolStripMenuItem.Text = "Camiones";
            // 
            // mnuGestionarCamiones
            // 
            this.mnuGestionarCamiones.Name = "mnuGestionarCamiones";
            this.mnuGestionarCamiones.Size = new System.Drawing.Size(178, 22);
            this.mnuGestionarCamiones.Text = "Gestionar camiones";
            this.mnuGestionarCamiones.Click += new System.EventHandler(this.mnuGestionarCamiones_Click);
            // 
            // choferesToolStripMenuItem
            // 
            this.choferesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestionarChoferes});
            this.choferesToolStripMenuItem.Name = "choferesToolStripMenuItem";
            this.choferesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.choferesToolStripMenuItem.Text = "Choferes";
            // 
            // mnuGestionarChoferes
            // 
            this.mnuGestionarChoferes.Name = "mnuGestionarChoferes";
            this.mnuGestionarChoferes.Size = new System.Drawing.Size(174, 22);
            this.mnuGestionarChoferes.Text = "Gestionar Choferes";
            this.mnuGestionarChoferes.Click += new System.EventHandler(this.mnuGestionarChoferes_Click);
            // 
            // rutasToolStripMenuItem
            // 
            this.rutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGestionarRutas});
            this.rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            this.rutasToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rutasToolStripMenuItem.Text = "Rutas";
            // 
            // mnuGestionarRutas
            // 
            this.mnuGestionarRutas.Name = "mnuGestionarRutas";
            this.mnuGestionarRutas.Size = new System.Drawing.Size(156, 22);
            this.mnuGestionarRutas.Text = "Gestionar Rutas";
            this.mnuGestionarRutas.Click += new System.EventHandler(this.mnuGestionarRutas_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(158, 22);
            this.mnuSalir.Text = "Salir del sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de Gestión de Camiones y Rutas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem camionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionarCamiones;
        private System.Windows.Forms.ToolStripMenuItem choferesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionarChoferes;
        private System.Windows.Forms.ToolStripMenuItem rutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGestionarRutas;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
    }
}

