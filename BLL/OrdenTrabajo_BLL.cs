using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public static class OrdenTrabajo_BLL
    {
        //referencia static de OrdenTrabajo Entity para poder instanciar

        private static OrdenTrabajo_DAL otDal;
       
        public static void  NewOrdenTrabajo(OrdenTrabajo ot)
        {

            otDal.InsertOT(ot);
            
        }       

    }
}
