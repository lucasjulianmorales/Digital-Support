using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SL;
using SL.Idioma;


namespace UI

{
    public partial class frmOrdenTrabajo : Form
    {
        public frmOrdenTrabajo()
        {
            InitializeComponent();
        }

        private void frmTecnico_Load(object sender, EventArgs e)
        {
            btnAddMateriales.Tag = "Agregar Materiales";
            btnAddServicios.Tag = "Agregar Servicios";
            btnFinalizarOT.Tag = "Finaliza OT";
            aBMMaterialesToolStripMenuItem.Tag = "";
        }

        private void aBMServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicio frmServicio = new frmServicio();
            frmServicio.ShowDialog();
        }

        private void btnAddServicios_Click(object sender, EventArgs e)
        {
            frmAddServicios frmAddServicios = new frmAddServicios();
            frmAddServicios.ShowDialog();
        }

        private void btnAddMateriales_Click(object sender, EventArgs e)
        {
            frmAddMateriales frmAddMateriales = new frmAddMateriales();
            frmAddMateriales.ShowDialog();
        }

        private void btnFinalizarOT_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultUser frmConsultUser = new frmConsultUser();
            frmConsultUser.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMUser frmAddUser = new frmABMUser();
            frmAddUser.ShowDialog();
        }

        private void aBMMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateriales frmMateriales = new frmMateriales();
            frmMateriales.ShowDialog();
        }

        private void cotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCotizacion frmCotizacion = new frmCotizacion();
            frmCotizacion.ShowDialog();

        }

        private void inglesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SL.Idioma.Idioma_SL cultura = new Idioma_SL();
            cultura.CambiarIdioma("en-US");
            MessageBox.Show("The language changed to English");
        }

        private void españolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El idioma cambio a Español");
        }

        private void menuOT_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnNewOT_Click(object sender, EventArgs e)
        {
            
        }
    }


}
