using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    static class ServicioOT_DAL
    {
        DigitalSupportDBDataContext DataContextDB = new DigitalSupportDBDataContext();
        private object otTable = new ORDENTRABAJO();

        public static List<ServicioOT> SelectAllServices()
        {
            List<ServicioOT> serviosOT = new List<ServicioOT>();
            


            return serviosOT;
        }


    }
}
