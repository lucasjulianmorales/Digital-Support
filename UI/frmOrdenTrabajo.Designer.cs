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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddServicios = new System.Windows.Forms.Button();
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.btnFinalizarOT = new System.Windows.Forms.Button();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 171);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnAddServicios
            // 
            this.btnAddServicios.Location = new System.Drawing.Point(765, 33);
            this.btnAddServicios.Name = "btnAddServicios";
            this.btnAddServicios.Size = new System.Drawing.Size(75, 53);
            this.btnAddServicios.TabIndex = 45;
            this.btnAddServicios.Text = "Agregar Servicios";
            this.btnAddServicios.UseVisualStyleBackColor = true;
            // 
            // btnAddMateriales
            // 
            this.btnAddMateriales.Location = new System.Drawing.Point(765, 92);
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.Size = new System.Drawing.Size(75, 53);
            this.btnAddMateriales.TabIndex = 44;
            this.btnAddMateriales.Text = "Agregar Materiales";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarOT
            // 
            this.btnFinalizarOT.Location = new System.Drawing.Point(765, 151);
            this.btnFinalizarOT.Name = "btnFinalizarOT";
            this.btnFinalizarOT.Size = new System.Drawing.Size(75, 53);
            this.btnFinalizarOT.TabIndex = 46;
            this.btnFinalizarOT.Text = "Finalizar OT";
            this.btnFinalizarOT.UseVisualStyleBackColor = true;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(12, 294);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(389, 117);
            this.txbDesc.TabIndex = 47;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(12, 267);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(87, 15);
            this.lbDesc.TabIndex = 48;
            this.lbDesc.Text = "Descripción:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.ordenDeTrabajoToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarToolStripMenuItem.Text = "Consultar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cotizacionToolStripMenuItem});
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Cotizacion";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMServiciosToolStripMenuItem,
            this.aBMMaterialesToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.serviciosToolStripMenuItem.Text = "Servicios y Materiales";
            // 
            // aBMServiciosToolStripMenuItem
            // 
            this.aBMServiciosToolStripMenuItem.Name = "aBMServiciosToolStripMenuItem";
            this.aBMServiciosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMServiciosToolStripMenuItem.Text = "ABM Servicios";
            this.aBMServiciosToolStripMenuItem.Click += new System.EventHandler(this.aBMServiciosToolStripMenuItem_Click);
            // 
            // aBMMaterialesToolStripMenuItem
            // 
            this.aBMMaterialesToolStripMenuItem.Name = "aBMMaterialesToolStripMenuItem";
            this.aBMMaterialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aBMMaterialesToolStripMenuItem.Text = "ABM  Materiales";
            // 
            // cotizacionToolStripMenuItem
            // 
            this.cotizacionToolStripMenuItem.Name = "cotizacionToolStripMenuItem";
            this.cotizacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cotizacionToolStripMenuItem.Text = "Cotizacion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // frmOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 423);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.btnFinalizarOT);
            this.Controls.Add(this.btnAddServicios);
            this.Controls.Add(this.btnAddMateriales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOrdenTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Trabajo - Digital Support";
            this.Load += new System.EventHandler(this.frmTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMaterialesToolStripMenuItem;
    }
}

