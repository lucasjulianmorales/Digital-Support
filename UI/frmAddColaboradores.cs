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
    public partial class frmAddColaboradores : Form
    {
        public frmAddColaboradores()
        {
            InitializeComponent();
        }

        private void frmAddColaboradores_Load(object sender, EventArgs e)
        {
            btnAddColaboradores.Tag = btnAddColaboradores.Text;
            btnSalir.Tag = btnSalir.Text;
            lbTecnicos.Tag = lbTecnicos.Text;
            lbAsignados.Tag = lbAsignados.Text;

        }
    }
}
