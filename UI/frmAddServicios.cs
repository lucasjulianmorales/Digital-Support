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
    public partial class frmAddServicios : Form
    {
        public frmAddServicios()
        {
            InitializeComponent();
        }

        private void frmAddServicios_Load(object sender, EventArgs e)
        {
            btnAddServicios.Tag = btnAddServicios.Text;
            btnSalir.Tag = btnSalir.Text;
            lbAsignados.Tag = lbAsignados.Text;
            lbCantidad.Tag = lbCantidad.Text;
            lbServicios.Tag = lbServicios.Text;
           
        }
    }
}
