using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public static class Orden_Trabajo_BLL
    {
        //utilizar las clases static es un

        private static Orden_Trabajo ordenTrabajo;

        public static Orden_Trabajo NewOrdenTrabajo()
        {
            ordenTrabajo = new Orden_Trabajo();

            return ordenTrabajo;
        }       

    }
}
