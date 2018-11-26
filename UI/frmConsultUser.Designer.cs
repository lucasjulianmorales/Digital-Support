namespace UI
{
    partial class frmConsultUser
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
            this.btnListUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDNI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListUser
            // 
            this.btnListUser.Location = new System.Drawing.Point(12, 382);
            this.btnListUser.Name = "btnListUser";
            this.btnListUser.Size = new System.Drawing.Size(75, 53);
            this.btnListUser.TabIndex = 51;
            this.btnListUser.Text = "Listar Usuarios";
            this.btnListUser.UseVisualStyleBackColor = true;
            this.btnListUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(105, 382);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 53);
            this.btnAddUser.TabIndex = 50;
            this.btnAddUser.Text = "Consultar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dgvUserList
            // 
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Location = new System.Drawing.Point(12, 12);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.Size = new System.Drawing.Size(642, 336);
            this.dgvUserList.TabIndex = 52;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(218, 379);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 15);
            this.lbUsuario.TabIndex = 61;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(452, 379);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(41, 15);
            this.lbPerfil.TabIndex = 60;
            this.lbPerfil.Text = "Perfil";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(452, 416);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(31, 15);
            this.lbDni.TabIndex = 59;
            this.lbDni.Text = "DNI";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(218, 416);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(59, 15);
            this.lbApellido.TabIndex = 58;
            this.lbApellido.Text = "Apellido";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(281, 378);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(152, 20);
            this.txbUsuario.TabIndex = 65;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(499, 377);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(155, 21);
            this.cmbPerfil.TabIndex = 66;
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(281, 415);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(152, 20);
            this.txbApellido.TabIndex = 67;
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(499, 415);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(155, 20);
            this.txbDNI.TabIndex = 68;
            // 
            // frmConsultUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 447);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.btnListUser);
            this.Controls.Add(this.btnAddUser);
            this.Name = "frmConsultUser";
            this.Text = "Usuarios - Digital Support";
            this.Load += new System.EventHandler(this.frmConsultUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDNI;
    }
}