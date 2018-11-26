using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public static class Cotizacion_BLL
    {
        private static Cotizacion cotizacion;

        public static Cotizacion NewCotizacion()
        {
            if (cotizacion == null)
            {
                cotizacion = new Cotizacion();
            }

            return cotizacion;

        }
    }
}
