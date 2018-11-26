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
        private static Orden_Trabajo ordenTrabajo;
        private static object syncLock = new object();


        public static Orden_Trabajo NewOrdenTrabajo()
        {
            if (ordenTrabajo == null)
            {
                lock (syncLock)
                {
                    if (ordenTrabajo == null)

                        ordenTrabajo = ;

                }
            }

            return ordenTrabajo;
        }

    }
}
