namespace UI
{
    partial class frmOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenTrabajo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddServicios = new System.Windows.Forms.Button();
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.btnFinalizarOT = new System.Windows.Forms.Button();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.menuOT = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewOT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuOT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // btnAddServicios
            // 
            resources.ApplyResources(this.btnAddServicios, "btnAddServicios");
            this.btnAddServicios.Name = "btnAddServicios";
            this.btnAddServicios.UseVisualStyleBackColor = true;
            this.btnAddServicios.Click += new System.EventHandler(this.btnAddServicios_Click);
            // 
            // btnAddMateriales
            // 
            resources.ApplyResources(this.btnAddMateriales, "btnAddMateriales");
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            this.btnAddMateriales.Click += new System.EventHandler(this.btnAddMateriales_Click);
            // 
            // btnFinalizarOT
            // 
            resources.ApplyResources(this.btnFinalizarOT, "btnFinalizarOT");
            this.btnFinalizarOT.Name = "btnFinalizarOT";
            this.btnFinalizarOT.UseVisualStyleBackColor = true;
            this.btnFinalizarOT.Click += new System.EventHandler(this.btnFinalizarOT_Click);
            // 
            // txbDesc
            // 
            resources.ApplyResources(this.txbDesc, "txbDesc");
            this.txbDesc.Name = "txbDesc";
            // 
            // lbDesc
            // 
            resources.ApplyResources(this.lbDesc, "lbDesc");
            this.lbDesc.Name = "lbDesc";
            // 
            // menuOT
            // 
            this.menuOT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            resources.ApplyResources(this.menuOT, "menuOT");
            this.menuOT.Name = "menuOT";
            this.menuOT.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuOT_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            resources.ApplyResources(this.cambiarContraseñaToolStripMenuItem, "cambiarContraseñaToolStripMenuItem");
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inglesToolStripMenuItem,
            this.españolToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            resources.ApplyResources(this.idiomaToolStripMenuItem, "idiomaToolStripMenuItem");
            // 
            // inglesToolStripMenuItem
            // 
            this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
            resources.ApplyResources(this.inglesToolStripMenuItem, "inglesToolStripMenuItem");
            this.inglesToolStripMenuItem.Click += new System.EventHandler(this.inglesToolStripMenuItem_Click);
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            resources.ApplyResources(this.españolToolStripMenuItem, "españolToolStripMenuItem");
            this.españolToolStripMenuItem.Click += new System.EventHandler(this.españolToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            resources.ApplyResources(this.usuarioToolStripMenuItem, "usuarioToolStripMenuItem");
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            resources.ApplyResources(this.buscarToolStripMenuItem, "buscarToolStripMenuItem");
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            resources.ApplyResources(this.agregarToolStripMenuItem, "agregarToolStripMenuItem");
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            resources.ApplyResources(this.perfilToolStripMenuItem, "perfilToolStripMenuItem");
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMServiciosToolStripMenuItem,
            this.aBMMaterialesToolStripMenuItem,
            this.cotizacionesToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            resources.ApplyResources(this.serviciosToolStripMenuItem, "serviciosToolStripMenuItem");
            // 
            // aBMServiciosToolStripMenuItem
            // 
            this.aBMServiciosToolStripMenuItem.Name = "aBMServiciosToolStripMenuItem";
            resources.ApplyResources(this.aBMServiciosToolStripMenuItem, "aBMServiciosToolStripMenuItem");
            this.aBMServiciosToolStripMenuItem.Click += new System.EventHandler(this.aBMServiciosToolStripMenuItem_Click);
            // 
            // aBMMaterialesToolStripMenuItem
            // 
            this.aBMMaterialesToolStripMenuItem.Name = "aBMMaterialesToolStripMenuItem";
            resources.ApplyResources(this.aBMMaterialesToolStripMenuItem, "aBMMaterialesToolStripMenuItem");
            this.aBMMaterialesToolStripMenuItem.Click += new System.EventHandler(this.aBMMaterialesToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            resources.ApplyResources(this.cotizacionesToolStripMenuItem, "cotizacionesToolStripMenuItem");
            // 
            // btnNewOT
            // 
            resources.ApplyResources(this.btnNewOT, "btnNewOT");
            this.btnNewOT.Name = "btnNewOT";
            this.btnNewOT.UseVisualStyleBackColor = true;
            this.btnNewOT.Click += new System.EventHandler(this.btnNewOT_Click);
            // 
            // frmOrdenTrabajo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewOT);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.btnFinalizarOT);
            this.Controls.Add(this.btnAddServicios);
            this.Controls.Add(this.btnAddMateriales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuOT);
            this.MainMenuStrip = this.menuOT;
            this.Name = "frmOrdenTrabajo";
            this.Load += new System.EventHandler(this.frmTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuOT.ResumeLayout(false);
            this.menuOT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddServicios;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.Button btnFinalizarOT;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.MenuStrip menuOT;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.Button btnNewOT;
    }
}

