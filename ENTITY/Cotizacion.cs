using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cotizacion
    {
        public DateTime Fecha_crea_cot { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public Usuario Creada_por { get; set; }
        public Estado ID_estado { get; set; }

    }
}