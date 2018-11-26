namespace UI
{
    partial class frmABMUser
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
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.lbPerfil = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDNI = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbCelular = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbLocalidad = new System.Windows.Forms.TextBox();
            this.lbLocalidad = new System.Windows.Forms.Label();
            this.txbCP = new System.Windows.Forms.TextBox();
            this.lbCodigoPostal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(335, 382);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 53);
            this.btnUpdateUser.TabIndex = 49;
            this.btnUpdateUser.Text = "Modificar Usuario";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(548, 382);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 53);
            this.btnDeleteUser.TabIndex = 48;
            this.btnDeleteUser.Text = "Eliminar Usuario";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(114, 40);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(193, 20);
            this.txbNombre.TabIndex = 46;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(446, 382);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 53);
            this.btnAddUser.TabIndex = 45;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(28, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 15);
            this.lbNombre.TabIndex = 50;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(28, 82);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(59, 15);
            this.lbApellido.TabIndex = 51;
            this.lbApellido.Text = "Apellido";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(28, 123);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(31, 15);
            this.lbDni.TabIndex = 52;
            this.lbDni.Text = "DNI";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(28, 205);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(53, 15);
            this.lbCelular.TabIndex = 53;
            this.lbCelular.Text = "Celular";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(28, 328);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(68, 15);
            this.lbDireccion.TabIndex = 54;
            this.lbDireccion.Text = "Direccion";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(446, 96);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(193, 21);
            this.cmbPerfil.TabIndex = 55;
            // 
            // lbPerfil
            // 
            this.lbPerfil.AutoSize = true;
            this.lbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerfil.Location = new System.Drawing.Point(369, 97);
            this.lbPerfil.Name = "lbPerfil";
            this.lbPerfil.Size = new System.Drawing.Size(41, 15);
            this.lbPerfil.TabIndex = 56;
            this.lbPerfil.Text = "Perfil";
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(369, 41);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(57, 15);
            this.lbUsuario.TabIndex = 57;
            this.lbUsuario.Text = "Usuario";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(28, 164);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(43, 15);
            this.lbMail.TabIndex = 58;
            this.lbMail.Text = "eMail";
            // 
            // txbApellido
            // 
            this.txbApellido.Location = new System.Drawing.Point(114, 81);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(193, 20);
            this.txbApellido.TabIndex = 59;
            // 
            // txbDNI
            // 
            this.txbDNI.Location = new System.Drawing.Point(114, 122);
            this.txbDNI.Name = "txbDNI";
            this.txbDNI.Size = new System.Drawing.Size(111, 20);
            this.txbDNI.TabIndex = 60;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(114, 163);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(193, 20);
            this.txbMail.TabIndex = 61;
            // 
            // txbCelular
            // 
            this.txbCelular.Location = new System.Drawing.Point(114, 204);
            this.txbCelular.Name = "txbCelular";
            this.txbCelular.Size = new System.Drawing.Size(193, 20);
            this.txbCelular.TabIndex = 62;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Location = new System.Drawing.Point(114, 327);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(193, 20);
            this.txbDireccion.TabIndex = 63;
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(446, 39);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(193, 20);
            this.txbUsuario.TabIndex = 64;
            // 
            // txbLocalidad
            // 
            this.txbLocalidad.Location = new System.Drawing.Point(114, 286);
            this.txbLocalidad.Name = "txbLocalidad";
            this.txbLocalidad.Size = new System.Drawing.Size(193, 20);
            this.txbLocalidad.TabIndex = 65;
            // 
            // lbLocalidad
            // 
            this.lbLocalidad.AutoSize = true;
            this.lbLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalidad.Location = new System.Drawing.Point(28, 286);
            this.lbLocalidad.Name = "lbLocalidad";
            this.lbLocalidad.Size = new System.Drawing.Size(70, 15);
            this.lbLocalidad.TabIndex = 66;
            this.lbLocalidad.Text = "Localidad";
            // 
            // txbCP
            // 
            this.txbCP.Location = new System.Drawing.Point(114, 245);
            this.txbCP.Name = "txbCP";
            this.txbCP.Size = new System.Drawing.Size(111, 20);
            this.txbCP.TabIndex = 67;
            // 
            // lbCodigoPostal
            // 
            this.lbCodigoPostal.AutoSize = true;
            this.lbCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoPostal.Location = new System.Drawing.Point(28, 248);
            this.lbCodigoPostal.Name = "lbCodigoPostal";
            this.lbCodigoPostal.Size = new System.Drawing.Size(25, 15);
            this.lbCodigoPostal.TabIndex = 68;
            this.lbCodigoPostal.Text = "CP";
            // 
            // frmABMUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 447);
            this.Controls.Add(this.lbCodigoPostal);
            this.Controls.Add(this.txbCP);
            this.Controls.Add(this.lbLocalidad);
            this.Controls.Add(this.txbLocalidad);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.txbCelular);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbDNI);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbPerfil);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbDni);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnAddUser);
            this.Name = "frmABMUser";
            this.Text = "ABM Usuarios - Digital Support";
            this.Load += new System.EventHandler(this.frmABMUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbDni;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.Label lbPerfil;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDNI;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbCelular;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbLocalidad;
        private System.Windows.Forms.Label lbLocalidad;
        private System.Windows.Forms.TextBox txbCP;
        private System.Windows.Forms.Label lbCodigoPostal;
    }
}