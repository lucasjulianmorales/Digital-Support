using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmABMUser : Form
    {
        public frmABMUser()
        {
            InitializeComponent();
        }

        private void frmABMUser_Load(object sender, EventArgs e)
        { 
            lbNombre.Tag = lbNombre.Text;
            lbApellido.Tag = lbApellido.Text;
            lbDni.Tag = lbDni.Text;
            lbMail.Tag = lbMail.Text;
            lbCodigoPostal.Tag = lbCodigoPostal.Text;
            lbCelular.Tag = lbCelular.Text;
            lbLocalidad.Tag = lbLocalidad.Text;
            lbDireccion.Tag = lbDireccion.Text;
            lbPerfil.Tag = lbPerfil.Text;
            lbUsuario.Tag = lbUsuario.Text;

            btnAddUser.Tag = btnAddUser.Text;
            btnDeleteUser.Tag = btnDeleteUser.Text;
            btnUpdateUser.Text = btnUpdateUser.Text;
        }
    }
}
