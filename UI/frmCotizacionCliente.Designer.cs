namespace UI
{
    partial class frmCotizacionCliente
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
            this.btnNewCotizacion = new System.Windows.Forms.Button();
            this.txbDescNecesidad = new System.Windows.Forms.TextBox();
            this.btnNewOT = new System.Windows.Forms.Button();
            this.dgvCotizacionCli = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacionCli)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCotizacion
            // 
            this.btnNewCotizacion.Location = new System.Drawing.Point(755, 358);
            this.btnNewCotizacion.Name = "btnNewCotizacion";
            this.btnNewCotizacion.Size = new System.Drawing.Size(75, 53);
            this.btnNewCotizacion.TabIndex = 0;
            this.btnNewCotizacion.Text = "Solicitar Cotizacion";
            this.btnNewCotizacion.UseVisualStyleBackColor = true;
            // 
            // txbDescNecesidad
            // 
            this.txbDescNecesidad.Location = new System.Drawing.Point(12, 241);
            this.txbDescNecesidad.Multiline = true;
            this.txbDescNecesidad.Name = "txbDescNecesidad";
            this.txbDescNecesidad.Size = new System.Drawing.Size(476, 170);
            this.txbDescNecesidad.TabIndex = 1;
            // 
            // btnNewOT
            // 
            this.btnNewOT.Location = new System.Drawing.Point(755, 283);
            this.btnNewOT.Name = "btnNewOT";
            this.btnNewOT.Size = new System.Drawing.Size(75, 53);
            this.btnNewOT.TabIndex = 2;
            this.btnNewOT.Text = "Nueva OT";
            this.btnNewOT.UseVisualStyleBackColor = true;
            // 
            // dgvCotizacionCli
            // 
            this.dgvCotizacionCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizacionCli.Location = new System.Drawing.Point(12, 40);
            this.dgvCotizacionCli.Name = "dgvCotizacionCli";
            this.dgvCotizacionCli.Size = new System.Drawing.Size(688, 152);
            this.dgvCotizacionCli.TabIndex = 3;
            this.dgvCotizacionCli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmCotizacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 423);
            this.Controls.Add(this.dgvCotizacionCli);
            this.Controls.Add(this.btnNewOT);
            this.Controls.Add(this.txbDescNecesidad);
            this.Controls.Add(this.btnNewCotizacion);
            this.Name = "frmCotizacionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotización -Digital Support";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacionCli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCotizacion;
        private System.Windows.Forms.TextBox txbDescNecesidad;
        private System.Windows.Forms.Button btnNewOT;
        private System.Windows.Forms.DataGridView dgvCotizacionCli;
    }
}