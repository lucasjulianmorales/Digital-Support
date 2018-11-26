using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public enum EstadoE
    {
        Arobado=6,
        Desaprobado,
        OK,
        Cancelar
    }        
    public class Cotizacion
    {
        public DateTime Fecha_crea_cot { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
        public Usuario Creada_por { get; set; }//insertar control en bitacora
        public int ID_estado { get; set; }

    }
}