namespace UI
{
    partial class frmServicio
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
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.lbServicios = new System.Windows.Forms.Label();
            this.btnAddServicios = new System.Windows.Forms.Button();
            this.btnUpdateServicio = new System.Windows.Forms.Button();
            this.btnDeleteServicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvServicios
            // 
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(12, 40);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(476, 307);
            this.dgvServicios.TabIndex = 0;
            // 
            // lbServicios
            // 
            this.lbServicios.AutoSize = true;
            this.lbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicios.Location = new System.Drawing.Point(12, 9);
            this.lbServicios.Name = "lbServicios";
            this.lbServicios.Size = new System.Drawing.Size(65, 15);
            this.lbServicios.TabIndex = 39;
            this.lbServicios.Text = "Servicios";
            // 
            // btnAddServicios
            // 
            this.btnAddServicios.Location = new System.Drawing.Point(413, 358);
            this.btnAddServicios.Name = "btnAddServicios";
            this.btnAddServicios.Size = new System.Drawing.Size(75, 53);
            this.btnAddServicios.TabIndex = 46;
            this.btnAddServicios.Text = "Agregar Servicio";
            this.btnAddServicios.UseVisualStyleBackColor = true;
            // 
            // btnUpdateServicio
            // 
            this.btnUpdateServicio.Location = new System.Drawing.Point(210, 358);
            this.btnUpdateServicio.Name = "btnUpdateServicio";
            this.btnUpdateServicio.Size = new System.Drawing.Size(75, 53);
            this.btnUpdateServicio.TabIndex = 47;
            this.btnUpdateServicio.Text = "Modificar Servicio";
            this.btnUpdateServicio.UseVisualStyleBackColor = true;
            // 
            // btnDeleteServicio
            // 
            this.btnDeleteServicio.Location = new System.Drawing.Point(12, 358);
            this.btnDeleteServicio.Name = "btnDeleteServicio";
            this.btnDeleteServicio.Size = new System.Drawing.Size(75, 53);
            this.btnDeleteServicio.TabIndex = 48;
            this.btnDeleteServicio.Text = "Eliminar Servicio";
            this.btnDeleteServicio.UseVisualStyleBackColor = true;
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.btnDeleteServicio);
            this.Controls.Add(this.btnUpdateServicio);
            this.Controls.Add(this.btnAddServicios);
            this.Controls.Add(this.lbServicios);
            this.Controls.Add(this.dgvServicios);
            this.Name = "frmServicio";
            this.Text = "frmNewServicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label lbServicios;
        private System.Windows.Forms.Button btnAddServicios;
        private System.Windows.Forms.Button btnUpdateServicio;
        private System.Windows.Forms.Button btnDeleteServicio;
    }
}