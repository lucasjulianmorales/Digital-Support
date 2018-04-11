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
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.btnAddServicios = new System.Windows.Forms.Button();
            this.btnSendCotizacion = new System.Windows.Forms.Button();
            this.txbDescNecesidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacionEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOTIZACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digita_SupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.dgvCotizacionEmp.Size = new System.Drawing.Size(688, 152);
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
            this.textBox1.Location = new System.Drawing.Point(722, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Monto:";
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
            // txbDescNecesidad
            // 
            this.txbDescNecesidad.Location = new System.Drawing.Point(12, 292);
            this.txbDescNecesidad.Multiline = true;
            this.txbDescNecesidad.Name = "txbDescNecesidad";
            this.txbDescNecesidad.Size = new System.Drawing.Size(347, 119);
            this.txbDescNecesidad.TabIndex = 45;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 423);
            this.Controls.Add(this.txbDescNecesidad);
            this.Controls.Add(this.btnSendCotizacion);
            this.Controls.Add(this.btnAddServicios);
            this.Controls.Add(this.btnAddMateriales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.dgvCotizacionEmp);
            this.Name = "frmCotizacion";
            this.Text = "Cotizacion - Digital Support";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacionEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOTIZACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digita_SupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.Button btnAddServicios;
        private System.Windows.Forms.Button btnSendCotizacion;
        private System.Windows.Forms.TextBox txbDescNecesidad;
    }
}