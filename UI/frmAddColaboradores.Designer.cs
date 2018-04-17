namespace UI
{
    partial class frmAddColaboradores
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
            this.btnAddColaboradores = new System.Windows.Forms.Button();
            this.lbAsignados = new System.Windows.Forms.Label();
            this.btnPasarTodoDer = new System.Windows.Forms.Button();
            this.btnPasarTodoIzq = new System.Windows.Forms.Button();
            this.lbTecnicos = new System.Windows.Forms.Label();
            this.btnPasarIzq = new System.Windows.Forms.Button();
            this.btnPasarDer = new System.Windows.Forms.Button();
            this.lstColaboradores = new System.Windows.Forms.ListBox();
            this.lstTecnicos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(413, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAddColaboradores
            // 
            this.btnAddColaboradores.Location = new System.Drawing.Point(211, 358);
            this.btnAddColaboradores.Name = "btnAddColaboradores";
            this.btnAddColaboradores.Size = new System.Drawing.Size(75, 53);
            this.btnAddColaboradores.TabIndex = 32;
            this.btnAddColaboradores.Text = "Asignar a OT";
            this.btnAddColaboradores.UseVisualStyleBackColor = true;
            // 
            // lbAsignados
            // 
            this.lbAsignados.AutoSize = true;
            this.lbAsignados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAsignados.Location = new System.Drawing.Point(305, 23);
            this.lbAsignados.Name = "lbAsignados";
            this.lbAsignados.Size = new System.Drawing.Size(73, 15);
            this.lbAsignados.TabIndex = 31;
            this.lbAsignados.Text = "Asignados";
            // 
            // btnPasarTodoDer
            // 
            this.btnPasarTodoDer.Location = new System.Drawing.Point(225, 281);
            this.btnPasarTodoDer.Name = "btnPasarTodoDer";
            this.btnPasarTodoDer.Size = new System.Drawing.Size(45, 23);
            this.btnPasarTodoDer.TabIndex = 30;
            this.btnPasarTodoDer.Text = ">>>";
            this.btnPasarTodoDer.UseVisualStyleBackColor = true;
            // 
            // btnPasarTodoIzq
            // 
            this.btnPasarTodoIzq.Location = new System.Drawing.Point(225, 220);
            this.btnPasarTodoIzq.Name = "btnPasarTodoIzq";
            this.btnPasarTodoIzq.Size = new System.Drawing.Size(45, 23);
            this.btnPasarTodoIzq.TabIndex = 29;
            this.btnPasarTodoIzq.Text = "<<<";
            this.btnPasarTodoIzq.UseVisualStyleBackColor = true;
            // 
            // lbTecnicos
            // 
            this.lbTecnicos.AutoSize = true;
            this.lbTecnicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTecnicos.Location = new System.Drawing.Point(12, 23);
            this.lbTecnicos.Name = "lbTecnicos";
            this.lbTecnicos.Size = new System.Drawing.Size(68, 15);
            this.lbTecnicos.TabIndex = 28;
            this.lbTecnicos.Text = "Tecnicos:";
            // 
            // btnPasarIzq
            // 
            this.btnPasarIzq.Location = new System.Drawing.Point(225, 98);
            this.btnPasarIzq.Name = "btnPasarIzq";
            this.btnPasarIzq.Size = new System.Drawing.Size(45, 23);
            this.btnPasarIzq.TabIndex = 27;
            this.btnPasarIzq.Text = "<";
            this.btnPasarIzq.UseVisualStyleBackColor = true;
            // 
            // btnPasarDer
            // 
            this.btnPasarDer.Location = new System.Drawing.Point(225, 159);
            this.btnPasarDer.Name = "btnPasarDer";
            this.btnPasarDer.Size = new System.Drawing.Size(45, 23);
            this.btnPasarDer.TabIndex = 26;
            this.btnPasarDer.Text = ">";
            this.btnPasarDer.UseVisualStyleBackColor = true;
            // 
            // lstColaboradores
            // 
            this.lstColaboradores.FormattingEnabled = true;
            this.lstColaboradores.Location = new System.Drawing.Point(308, 58);
            this.lstColaboradores.Name = "lstColaboradores";
            this.lstColaboradores.Size = new System.Drawing.Size(175, 290);
            this.lstColaboradores.TabIndex = 25;
            // 
            // lstTecnicos
            // 
            this.lstTecnicos.FormattingEnabled = true;
            this.lstTecnicos.Location = new System.Drawing.Point(12, 58);
            this.lstTecnicos.Name = "lstTecnicos";
            this.lstTecnicos.Size = new System.Drawing.Size(175, 290);
            this.lstTecnicos.TabIndex = 24;
            // 
            // frmAddColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAddColaboradores);
            this.Controls.Add(this.lbAsignados);
            this.Controls.Add(this.btnPasarTodoDer);
            this.Controls.Add(this.btnPasarTodoIzq);
            this.Controls.Add(this.lbTecnicos);
            this.Controls.Add(this.btnPasarIzq);
            this.Controls.Add(this.btnPasarDer);
            this.Controls.Add(this.lstColaboradores);
            this.Controls.Add(this.lstTecnicos);
            this.Name = "frmAddColaboradores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Colaboradores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddColaboradores;
        private System.Windows.Forms.Label lbAsignados;
        private System.Windows.Forms.Button btnPasarTodoDer;
        private System.Windows.Forms.Button btnPasarTodoIzq;
        private System.Windows.Forms.Label lbTecnicos;
        private System.Windows.Forms.Button btnPasarIzq;
        private System.Windows.Forms.Button btnPasarDer;
        private System.Windows.Forms.ListBox lstColaboradores;
        private System.Windows.Forms.ListBox lstTecnicos;
    }
}