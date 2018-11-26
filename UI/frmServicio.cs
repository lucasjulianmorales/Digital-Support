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
    public partial class frmServicio : Form
    {
        public frmServicio()
        {
            InitializeComponent();
        }

        private void frmServicio_Load(object sender, EventArgs e)
        {
            btnAddServicios.Tag = btnAddServicios.Text;
            btnDeleteServicio.Tag = btnDeleteServicio.Text;
            btnUpdateServicio.Tag = btnUpdateServicio;
            lbServicios.Tag = lbServicios.Text;

            ServicioControlTraductor.TraducirFormulario(this);
        }
    }
}
