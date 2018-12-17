using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.Data.Sql;
using System.Configuration;

namespace DAL
{
    public  class OrdenTrabajo_DAL
    {

        DigitalSupportDBDataContext DataContextDB = new DigitalSupportDBDataContext();

        private  object otTable = new ORDENTRABAJO();

        private  string conectionString = ConfigurationManager.ConnectionStrings["DigitalSupportDB"].ToString();

        public  object DataClassesDataContext { get; private set; }

        public void InsertOT(OrdenTrabajo ot)
        {
            DataContextDB.ORDENTRABAJO.InsertOnSubmit((ORDENTRABAJO)ot);
            
            // Submit the change to the database.
            try
            {
                DataContextDB.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Make some adjustments.
                // ...
                // Try again.
                DataContextDB.SubmitChanges();
            }

        }
    }
}
