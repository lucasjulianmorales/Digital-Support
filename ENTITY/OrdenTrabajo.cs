using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class OrdenTrabajo
    {
        public Guid _ID_ot{ get; set; } 
        public DateTime _Fecha_Creacion { get; set; }
        public DateTime _Fecha_Finalizacion { get; set; }
        public Prioridad _Prioridad { get; set; }
        public C
        public string _Desc_Resolucion { get; set; }
        public string _Desc_Sactisfaccion { get; set; }

        public OrdenTrabajo(int prioridad, int clasificacion, DateTime fechaCreacion )
        {
            _ID_ot = Guid.NewGuid();
            _Prioridad = (Prioridad)prioridad;
            _Clasificacion = 
            _Fecha_Creacion = fechaCreacion;


        }

    }
    public enum Prioridad
    {
        Baja,Media,Alta
    }

    public enum Clasificacion
    {

    }

  
}
