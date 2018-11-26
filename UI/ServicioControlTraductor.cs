using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class ServicioControlTraductor
    {

        public static void TraducirFormulario(Form formulario)
        {

            
            foreach (Control c in formulario.Controls)
            {
                if (c.Tag != null)
                {
                    SL.Idioma.Idioma_SL sl = new SL.Idioma.Idioma_SL();
                    c.Text = sl.Traducir(c.Tag.ToString());
                }
            }
        }
    }
}
