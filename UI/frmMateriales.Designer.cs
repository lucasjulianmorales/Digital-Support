namespace UI
{
    partial class frmMateriales
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
            this.btnDeleteMateriales = new System.Windows.Forms.Button();
            this.btnUpdateServicio = new System.Windows.Forms.Button();
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.lbMateriales = new System.Windows.Forms.Label();
            this.dgvListMateriales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteMateriales
            // 
            this.btnDeleteMateriales.Location = new System.Drawing.Point(12, 359);
            this.btnDeleteMateriales.Name = "btnDeleteMateriales";
            this.btnDeleteMateriales.Size = new System.Drawing.Size(75, 53);
            this.btnDeleteMateriales.TabIndex = 53;
            this.btnDeleteMateriales.Text = "Eliminar Materiales";
            this.btnDeleteMateriales.UseVisualStyleBackColor = true;
            // 
            // btnUpdateServicio
            // 
            this.btnUpdateServicio.Location = new System.Drawing.Point(210, 359);
            this.btnUpdateServicio.Name = "btnUpdateServicio";
            this.btnUpdateServicio.Size = new System.Drawing.Size(75, 53);
            this.btnUpdateServicio.TabIndex = 52;
            this.btnUpdateServicio.Text = "Modificar Materiales";
            this.btnUpdateServicio.UseVisualStyleBackColor = true;
            // 
            // btnAddMateriales
            // 
            this.btnAddMateriales.Location = new System.Drawing.Point(413, 359);
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.Size = new System.Drawing.Size(75, 53);
            this.btnAddMateriales.TabIndex = 51;
            this.btnAddMateriales.Text = "Agregar Materiales";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            // 
            // lbMateriales
            // 
            this.lbMateriales.AutoSize = true;
            this.lbMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMateriales.Location = new System.Drawing.Point(12, 10);
            this.lbMateriales.Name = "lbMateriales";
            this.lbMateriales.Size = new System.Drawing.Size(75, 15);
            this.lbMateriales.TabIndex = 50;
            this.lbMateriales.Text = "Materiales";
            // 
            // dgvListMateriales
            // 
            this.dgvListMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMateriales.Location = new System.Drawing.Point(12, 41);
            this.dgvListMateriales.Name = "dgvListMateriales";
            this.dgvListMateriales.Size = new System.Drawing.Size(476, 307);
            this.dgvListMateriales.TabIndex = 49;
            // 
            // frmMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.btnDeleteMateriales);
            this.Controls.Add(this.btnUpdateServicio);
            this.Controls.Add(this.btnAddMateriales);
            this.Controls.Add(this.lbMateriales);
            this.Controls.Add(this.dgvListMateriales);
            this.Name = "frmMateriales";
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.frmMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteMateriales;
        private System.Windows.Forms.Button btnUpdateServicio;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.Label lbMateriales;
        private System.Windows.Forms.DataGridView dgvListMateriales;
    }
}