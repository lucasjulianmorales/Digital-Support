namespace UI
{
    partial class frmCotizacion
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
            this.components = new System.ComponentModel.Container();
            this.dgvCotizacionEmp = new System.Windows.Forms.DataGridView();
            this.iDcotizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feccreacotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadaporDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOTIZACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.digita_SupportDataSet = new UI.Digita_SupportDataSet();
            this.cOTIZACIONTableAdapter = new UI.Digita_SupportDataSetTableAdapters.COTIZACIONTableAdapter();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbMonto = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.btnAddServicios = new System.Windows.Forms.Button();
            this.btnSendCotizacion = new System.Windows.Forms.Button();
            this.lbDesc = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.btnNewCotizacion = new System.Windows.Forms.Button();
            this.menuOT = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacionEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOTIZACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digita_SupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuOT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCotizacionEmp
            // 
            this.dgvCotizacionEmp.AutoGenerateColumns = false;
            this.dgvCotizacionEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizacionEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcotizacionDataGridViewTextBoxColumn,
            this.feccreacotDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.creadaporDataGridViewTextBoxColumn});
            this.dgvCotizacionEmp.DataSource = this.cOTIZACIONBindingSource;
            this.dgvCotizacionEmp.Location = new System.Drawing.Point(12, 45);
            this.dgvCotizacionEmp.Name = "dgvCotizacionEmp";
            this.dgvCotizacionEmp.Size = new System.Drawing.Size(688, 203);
            this.dgvCotizacionEmp.TabIndex = 0;
            // 
            // iDcotizacionDataGridViewTextBoxColumn
            // 
            this.iDcotizacionDataGridViewTextBoxColumn.DataPropertyName = "ID_cotizacion";
            this.iDcotizacionDataGridViewTextBoxColumn.HeaderText = "ID_cotizacion";
            this.iDcotizacionDataGridViewTextBoxColumn.Name = "iDcotizacionDataGridViewTextBoxColumn";
            // 
            // feccreacotDataGridViewTextBoxColumn
            // 
            this.feccreacotDataGridViewTextBoxColumn.DataPropertyName = "Fec_crea_cot";
            this.feccreacotDataGridViewTextBoxColumn.HeaderText = "Fec_crea_cot";
            this.feccreacotDataGridViewTextBoxColumn.Name = "feccreacotDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // creadaporDataGridViewTextBoxColumn
            // 
            this.creadaporDataGridViewTextBoxColumn.DataPropertyName = "Creada_por";
            this.creadaporDataGridViewTextBoxColumn.HeaderText = "Creada_por";
            this.creadaporDataGridViewTextBoxColumn.Name = "creadaporDataGridViewTextBoxColumn";
            // 
            // cOTIZACIONBindingSource
            // 
            this.cOTIZACIONBindingSource.DataMember = "COTIZACION";
            this.cOTIZACIONBindingSource.DataSource = this.digita_SupportDataSet;
            // 
            // digita_SupportDataSet
            // 
            this.digita_SupportDataSet.DataSetName = "Digita_SupportDataSet";
            this.digita_SupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOTIZACIONTableAdapter
            // 
            this.cOTIZACIONTableAdapter.ClearBeforeFill = true;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(736, 181);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 53);
            this.btnCotizar.TabIndex = 23;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 35;
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonto.Location = new System.Drawing.Point(463, 279);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(51, 15);
            this.lbMonto.TabIndex = 36;
            this.lbMonto.Text = "Monto:";
            // 
            // btnAddMateriales
            // 
            this.btnAddMateriales.Location = new System.Drawing.Point(736, 103);
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.Size = new System.Drawing.Size(75, 53);
            this.btnAddMateriales.TabIndex = 39;
            this.btnAddMateriales.Text = "Agregar Materiales";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            // 
            // btnAddServicios
            // 
            this.btnAddServicios.Location = new System.Drawing.Point(736, 28);
            this.btnAddServicios.Name = "btnAddServicios";
            this.btnAddServicios.Size = new System.Drawing.Size(75, 53);
            this.btnAddServicios.TabIndex = 43;
            this.btnAddServicios.Text = "Agregar Servicios";
            this.btnAddServicios.UseVisualStyleBackColor = true;
            // 
            // btnSendCotizacion
            // 
            this.btnSendCotizacion.Location = new System.Drawing.Point(736, 261);
            this.btnSendCotizacion.Name = "btnSendCotizacion";
            this.btnSendCotizacion.Size = new System.Drawing.Size(75, 53);
            this.btnSendCotizacion.TabIndex = 44;
            this.btnSendCotizacion.Text = "Enviar Cotizacion";
            this.btnSendCotizacion.UseVisualStyleBackColor = true;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(12, 251);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(87, 15);
            this.lbDesc.TabIndex = 50;
            this.lbDesc.Text = "Descripción:";
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(12, 278);
            this.txbDesc.Multiline = true;
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(389, 117);
            this.txbDesc.TabIndex = 49;
            // 
            // btnNewCotizacion
            // 
            this.btnNewCotizacion.Location = new System.Drawing.Point(736, 342);
            this.btnNewCotizacion.Name = "btnNewCotizacion";
            this.btnNewCotizacion.Size = new System.Drawing.Size(75, 53);
            this.btnNewCotizacion.TabIndex = 51;
            this.btnNewCotizacion.Text = "Nueva Cotizacion";
            this.btnNewCotizacion.UseVisualStyleBackColor = true;
            this.btnNewCotizacion.Click += new System.EventHandler(this.btnNewCotizacion_Click);
            // 
            // menuOT
            // 
            this.menuOT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.serviciosToolStripMenuItem});
            this.menuOT.Location = new System.Drawing.Point(0, 0);
            this.menuOT.Name = "menuOT";
            this.menuOT.Size = new System.Drawing.Size(862, 24);
            this.menuOT.TabIndex = 52;
            this.menuOT.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CambiarContraseñaToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // CambiarContraseñaToolStripMenuItem
            // 
            this.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem";
            this.CambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.CambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inglesToolStripMenuItem,
            this.españolToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // inglesToolStripMenuItem
            // 
            this.inglesToolStripMenuItem.Name = "inglesToolStripMenuItem";
            this.inglesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inglesToolStripMenuItem.Text = "English";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.españolToolStripMenuItem.Text = "Español";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.perfilToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.buscarToolStripMenuItem.Text = "Consultar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.agregarToolStripMenuItem.Text = "ABM Usuario";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMServiciosToolStripMenuItem,
            this.aBMMaterialesToolStripMenuItem,
            this.cotizacionesToolStripMenuItem});
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.serviciosToolStripMenuItem.Text = "Utilidades";
            // 
            // aBMServiciosToolStripMenuItem
            // 
            this.aBMServiciosToolStripMenuItem.Name = "aBMServiciosToolStripMenuItem";
            this.aBMServiciosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aBMServiciosToolStripMenuItem.Text = "ABM Servicio";
            // 
            // aBMMaterialesToolStripMenuItem
            // 
            this.aBMMaterialesToolStripMenuItem.Name = "aBMMaterialesToolStripMenuItem";
            this.aBMMaterialesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aBMMaterialesToolStripMenuItem.Text = "ABM  Material";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cotizacionesToolStripMenuItem.Text = "Orden de Trabajo";
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 423);
            this.Controls.Add(this.menuOT);
            this.Controls.Add(this.btnNewCotizacion);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.btnSendCotizacion);
            this.Controls.Add(this.btnAddServicios);
            this.Controls.Add(this.btnAddMateriales);
            this.Controls.Add(this.lbMonto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.dgvCotizacionEmp);
            this.Name = "frmCotizacion";
            this.Text = "Cotización - Digital Support";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacionEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOTIZACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digita_SupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuOT.ResumeLayout(false);
            this.menuOT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCotizacionEmp;
        private Digita_SupportDataSet digita_SupportDataSet;
        private System.Windows.Forms.BindingSource cOTIZACIONBindingSource;
        private Digita_SupportDataSetTableAdapters.COTIZACIONTableAdapter cOTIZACIONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcotizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feccreacotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadaporDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.Button btnAddServicios;
        private System.Windows.Forms.Button btnSendCotizacion;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Button btnNewCotizacion;
        private System.Windows.Forms.MenuStrip menuOT;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
    }
}