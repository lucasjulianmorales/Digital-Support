using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;
using SL;

namespace UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario();
            user.User_name = txbUser.Text;
            user.Password = txbPass.Text;

            Usuario_BLL.LogIn(user);
            frmOrdenTrabajo frmOT = new frmOrdenTrabajo();
            
            if (user != null)
            {
                frmOT.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ingreso denegado usuario o contraseña incorrecta");
            }

            frmOT.Dispose();

            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lbContraseña.Tag = lbContraseña.Text;
            lbUsuario.Tag = lbUsuario.Text;
            btnLogIn.Tag = btnLogIn.Text;
            ServicioControlTraductor.TraducirFormulario(this);

        }
    }
}
