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
    public partial class frmCotizacion : Form
    {
        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'digita_SupportDataSet.COTIZACION' Puede moverla o quitarla según sea necesario.
            this.cOTIZACIONTableAdapter.Fill(this.digita_SupportDataSet.COTIZACION);

        }
    }
}
