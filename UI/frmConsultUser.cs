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
    public partial class frmConsultUser : Form
    {
        public frmConsultUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultUser_Load(object sender, EventArgs e)
        {
            btnAddUser.Tag = btnAddUser.Text;
            btnListUser.Tag = btnListUser.Text;
            lbPerfil.Tag = lbPerfil.Text;
            lbUsuario.Tag = lbUsuario.Text;
            lbDni.Tag = lbDni.Text;
            lbApellido.Tag = lbApellido.Text;
        }
    }
}
