namespace UI
{
    partial class frmAddMateriales
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
            this.lstMaterialesUtilizados = new System.Windows.Forms.ListBox();
            this.lstMateriales = new System.Windows.Forms.ListBox();
            this.lbMateriales = new System.Windows.Forms.Label();
            this.lbUtilizados = new System.Windows.Forms.Label();
            this.btnAddMateriales = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPasarTodoDer = new System.Windows.Forms.Button();
            this.btnPasarTodoIzq = new System.Windows.Forms.Button();
            this.btnPasarIzq = new System.Windows.Forms.Button();
            this.btnPasarDer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMaterialesUtilizados
            // 
            this.lstMaterialesUtilizados.FormattingEnabled = true;
            this.lstMaterialesUtilizados.Location = new System.Drawing.Point(308, 58);
            this.lstMaterialesUtilizados.Name = "lstMaterialesUtilizados";
            this.lstMaterialesUtilizados.Size = new System.Drawing.Size(175, 290);
            this.lstMaterialesUtilizados.TabIndex = 13;
            // 
            // lstMateriales
            // 
            this.lstMateriales.FormattingEnabled = true;
            this.lstMateriales.Location = new System.Drawing.Point(12, 58);
            this.lstMateriales.Name = "lstMateriales";
            this.lstMateriales.Size = new System.Drawing.Size(175, 290);
            this.lstMateriales.TabIndex = 12;
            // 
            // lbMateriales
            // 
            this.lbMateriales.AutoSize = true;
            this.lbMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMateriales.Location = new System.Drawing.Point(12, 25);
            this.lbMateriales.Name = "lbMateriales";
            this.lbMateriales.Size = new System.Drawing.Size(79, 15);
            this.lbMateriales.TabIndex = 18;
            this.lbMateriales.Text = "Materiales:";
            // 
            // lbUtilizados
            // 
            this.lbUtilizados.AutoSize = true;
            this.lbUtilizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtilizados.Location = new System.Drawing.Point(306, 25);
            this.lbUtilizados.Name = "lbUtilizados";
            this.lbUtilizados.Size = new System.Drawing.Size(75, 15);
            this.lbUtilizados.TabIndex = 21;
            this.lbUtilizados.Text = "Utilizados:";
            // 
            // btnAddMateriales
            // 
            this.btnAddMateriales.Location = new System.Drawing.Point(212, 358);
            this.btnAddMateriales.Name = "btnAddMateriales";
            this.btnAddMateriales.Size = new System.Drawing.Size(75, 53);
            this.btnAddMateriales.TabIndex = 22;
            this.btnAddMateriales.Text = "Agregar Materiales";
            this.btnAddMateriales.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(413, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnPasarTodoDer
            // 
            this.btnPasarTodoDer.Location = new System.Drawing.Point(225, 281);
            this.btnPasarTodoDer.Name = "btnPasarTodoDer";
            this.btnPasarTodoDer.Size = new System.Drawing.Size(45, 23);
            this.btnPasarTodoDer.TabIndex = 34;
            this.btnPasarTodoDer.Text = ">>>";
            this.btnPasarTodoDer.UseVisualStyleBackColor = true;
            // 
            // btnPasarTodoIzq
            // 
            this.btnPasarTodoIzq.Location = new System.Drawing.Point(225, 220);
            this.btnPasarTodoIzq.Name = "btnPasarTodoIzq";
            this.btnPasarTodoIzq.Size = new System.Drawing.Size(45, 23);
            this.btnPasarTodoIzq.TabIndex = 33;
            this.btnPasarTodoIzq.Text = "<<<";
            this.btnPasarTodoIzq.UseVisualStyleBackColor = true;
            // 
            // btnPasarIzq
            // 
            this.btnPasarIzq.Location = new System.Drawing.Point(225, 98);
            this.btnPasarIzq.Name = "btnPasarIzq";
            this.btnPasarIzq.Size = new System.Drawing.Size(45, 23);
            this.btnPasarIzq.TabIndex = 32;
            this.btnPasarIzq.Text = "<";
            this.btnPasarIzq.UseVisualStyleBackColor = true;
            // 
            // btnPasarDer
            // 
            this.btnPasarDer.Location = new System.Drawing.Point(225, 159);
            this.btnPasarDer.Name = "btnPasarDer";
            this.btnPasarDer.Size = new System.Drawing.Size(45, 23);
            this.btnPasarDer.TabIndex = 31;
            this.btnPasarDer.Text = ">";
            this.btnPasarDer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 47;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(12, 388);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(68, 15);
            this.lbCantidad.TabIndex = 46;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // frmAddMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.btnPasarTodoDer);
            this.Controls.Add(this.btnPasarTodoIzq);
            this.Controls.Add(this.btnPasarIzq);
            this.Controls.Add(this.btnPasarDer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAddMateriales);
            this.Controls.Add(this.lbUtilizados);
            this.Controls.Add(this.lbMateriales);
            this.Controls.Add(this.lstMaterialesUtilizados);
            this.Controls.Add(this.lstMateriales);
            this.Name = "frmAddMateriales";
            this.Text = "Agregar Materiales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstMaterialesUtilizados;
        private System.Windows.Forms.ListBox lstMateriales;
        private System.Windows.Forms.Label lbMateriales;
        private System.Windows.Forms.Label lbUtilizados;
        private System.Windows.Forms.Button btnAddMateriales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPasarTodoDer;
        private System.Windows.Forms.Button btnPasarTodoIzq;
        private System.Windows.Forms.Button btnPasarIzq;
        private System.Windows.Forms.Button btnPasarDer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbCantidad;
    }
}