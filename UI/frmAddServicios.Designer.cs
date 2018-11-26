namespace UI
{
    partial class frmAddServicios
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAddServicios = new System.Windows.Forms.Button();
            this.lbAsignados = new System.Windows.Forms.Label();
            this.btnPasarTodoDer = new System.Windows.Forms.Button();
            this.btnPasarTodoIzq = new System.Windows.Forms.Button();
            this.lbServicios = new System.Windows.Forms.Label();
            this.btnPasarIzq = new System.Windows.Forms.Button();
            this.btnPasarDer = new System.Windows.Forms.Button();
            this.lstServiciosPrestados = new System.Windows.Forms.ListBox();
            this.lstServicios = new System.Windows.Forms.ListBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(413, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAddServicios
            // 
            this.btnAddServicios.Location = new System.Drawing.Point(211, 358);
            this.btnAddServicios.Name = "btnAddServicios";
            this.btnAddServicios.Size = new System.Drawing.Size(75, 53);
            this.btnAddServicios.TabIndex = 42;
            this.btnAddServicios.Text = "Agregar Servicios";
            this.btnAddServicios.UseVisualStyleBackColor = true;
            // 
            // lbAsignados
            // 
            this.lbAsignados.AutoSize = true;
            this.lbAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsignados.Location = new System.Drawing.Point(305, 23);
            this.lbAsignados.Name = "lbAsignados";
            this.lbAsignados.Size = new System.Drawing.Size(73, 15);
            this.lbAsignados.TabIndex = 41;
            this.lbAsignados.Text = "Asignados";
            // 
            // btnPasarTodoDer
            // 
            this.btnPasarTodoDer.Location = new System.Drawing.Point(225, 281);
            this.btnPasarTodoDer.Name = "btnPasarTodoDer";
            this.btnPasarTodoDer.Size = new System.Drawing.Size(45, 23);
            this.btnPasarTodoDer.TabIndex = 40;
            this.btnPasarTodoDer.Text = ">>>";
            this.btnPasarTodoDer.UseVisualStyleBackColor = true;
            // 
            // btnPasarTodoIzq
            // 
            this.btnPasarTodoIzq.Location = new System.Drawing.Point(225, 220);
            this.btnPasarTodoIzq.Name = "btnPasarTodoIzq";
            this.btnPasarTodoIzq.Size = new System.Drawing.Size(45, 23);
            this.btnPasarTodoIzq.TabIndex = 39;
            this.btnPasarTodoIzq.Text = "<<<";
            this.btnPasarTodoIzq.UseVisualStyleBackColor = true;
            // 
            // lbServicios
            // 
            this.lbServicios.AutoSize = true;
            this.lbServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicios.Location = new System.Drawing.Point(12, 23);
            this.lbServicios.Name = "lbServicios";
            this.lbServicios.Size = new System.Drawing.Size(65, 15);
            this.lbServicios.TabIndex = 38;
            this.lbServicios.Text = "Servicios";
            // 
            // btnPasarIzq
            // 
            this.btnPasarIzq.Location = new System.Drawing.Point(225, 98);
            this.btnPasarIzq.Name = "btnPasarIzq";
            this.btnPasarIzq.Size = new System.Drawing.Size(45, 23);
            this.btnPasarIzq.TabIndex = 37;
            this.btnPasarIzq.Text = "<";
            this.btnPasarIzq.UseVisualStyleBackColor = true;
            // 
            // btnPasarDer
            // 
            this.btnPasarDer.Location = new System.Drawing.Point(225, 159);
            this.btnPasarDer.Name = "btnPasarDer";
            this.btnPasarDer.Size = new System.Drawing.Size(45, 23);
            this.btnPasarDer.TabIndex = 36;
            this.btnPasarDer.Text = ">";
            this.btnPasarDer.UseVisualStyleBackColor = true;
            // 
            // lstServiciosPrestados
            // 
            this.lstServiciosPrestados.FormattingEnabled = true;
            this.lstServiciosPrestados.Location = new System.Drawing.Point(308, 58);
            this.lstServiciosPrestados.Name = "lstServiciosPrestados";
            this.lstServiciosPrestados.Size = new System.Drawing.Size(175, 290);
            this.lstServiciosPrestados.TabIndex = 35;
            // 
            // lstServicios
            // 
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.Location = new System.Drawing.Point(12, 58);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(175, 290);
            this.lstServicios.TabIndex = 34;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(12, 388);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(64, 15);
            this.lbCantidad.TabIndex = 44;
            this.lbCantidad.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 383);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 45;
            // 
            // frmAddServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAddServicios);
            this.Controls.Add(this.lbAsignados);
            this.Controls.Add(this.btnPasarTodoDer);
            this.Controls.Add(this.btnPasarTodoIzq);
            this.Controls.Add(this.lbServicios);
            this.Controls.Add(this.btnPasarIzq);
            this.Controls.Add(this.btnPasarDer);
            this.Controls.Add(this.lstServiciosPrestados);
            this.Controls.Add(this.lstServicios);
            this.Name = "frmAddServicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Servicios";
            this.Load += new System.EventHandler(this.frmAddServicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddServicios;
        private System.Windows.Forms.Label lbAsignados;
        private System.Windows.Forms.Button btnPasarTodoDer;
        private System.Windows.Forms.Button btnPasarTodoIzq;
        private System.Windows.Forms.Label lbServicios;
        private System.Windows.Forms.Button btnPasarIzq;
        private System.Windows.Forms.Button btnPasarDer;
        private System.Windows.Forms.ListBox lstServiciosPrestados;
        private System.Windows.Forms.ListBox lstServicios;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.TextBox textBox1;
    }
}